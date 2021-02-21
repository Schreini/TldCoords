using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace TldCoords
{
    public partial class Form1 : Form
    {
        private readonly FileSystemWatcher _watcher;
        private readonly ConcurrentBag<string> _filesToMove = new ConcurrentBag<string>();
        private readonly BackgroundWorker _worker = new BackgroundWorker();

        private delegate void SafeCallDelegate(Label label, float coords);

        private readonly Canvas _canvas = new Canvas();
        
        public Form1()
        {
            InitializeComponent();
            _canvas.Location = new Point(400, 12);
            _canvas.Size = new Size(100, 114);
            Controls.Add(_canvas);

            _watcher = new FileSystemWatcher();
            _watcher.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _watcher.Filter = "*.png";

            // Add event handlers.
            _watcher.Created += OnCreated;

            // Begin watching.
            _watcher.EnableRaisingEvents = true;

            _worker.DoWork += WorkerOnDoWork;
            _worker.RunWorkerAsync();
        }

        private void WorkerOnDoWork(object? sender, DoWorkEventArgs e)
        {
            while (true)
            {
                while (_filesToMove.TryTake(out string? file))
                {
                    try
                    {
                        File.Move(file, @$"E:\TheLongDark\MappingAshCanyon\All\{Path.GetFileName(file)}", true);
                    }
                    catch
                    {
                        _filesToMove.Add(file);
                    }
                }
                Thread.Sleep(1000);
            }
        }


        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            //screen_(-100, -54, 163)_31e25ba6-5e32-4826-ade2-972bbc218632
            var regex = new Regex(@"screen_\((?<x>-?\d+), (?<z>-?\d+), (?<y>-?\d+)\)_.*\.png");
            var match = regex.Match(e.Name ?? "");
            if (!match.Success) return;

            var minx = -885; //koordinaten.Min(k => k.X);
            var maxx = 914; //koordinaten.Max(k => k.X);
            var miny = -904; //koordinaten.Min(k => k.Y);
            var maxy = 899; //koordinaten.Max(k => k.Y);
            var minz = 1; //koordinaten.Min(k => k.Z);
            var maxz = 392; //koordinaten.Max(k => k.Z);

            var k = new Koordinaten()
            {
                XReal = Convert.ToInt32(match.Groups["x"].Value),
                YReal = Convert.ToInt32(match.Groups["y"].Value),
                ZReal = Convert.ToInt32(match.Groups["z"].Value)
            };
            // alle Kordinaten positiv machen
            k = new Koordinaten()
                {XReal = k.XReal + minx * -1, YReal = k.YReal + miny * -1, ZReal = k.ZReal + minz * -1};

            var distx = maxx - minx;
            var disty = maxy - miny;

            // calculate  distances
            var maxdist = Math.Max(distx, disty);
            var div = maxdist / 60m; //Noppen

            k = new Koordinaten()
            {
                XReal = k.XReal,
                YReal = k.YReal,
                ZReal = k.ZReal,
                X = Convert.ToInt32(Math.Round(k.XReal / div, 0)),
                Y = Convert.ToInt32(Math.Round(k.YReal / div, 0)),
                Z = Convert.ToInt32(Math.Round(k.ZReal * 3 / div, 0))
            };

            _canvas.SetCoordinates(k);
            
            SetLabelText(LblXReal, k.XReal);
            SetLabelText(LblYReal, k.YReal);
            SetLabelText(LblZReal, k.ZReal);
            SetLabelText(LblX, k.X);
            SetLabelText(LblY, k.Y);
            SetLabelText(LblZ, k.Z);

            _filesToMove.Add(e.FullPath);

            using var fw = File.AppendText($@"{_watcher.Path}\xyz.tsv");
            fw.WriteLine(string.Join('\t', k.X, k.Y, k.Z, k.XReal, k.YReal, k.ZReal));
            fw.Close();
        }

        private void SetLabelText(Label label, float coords)
        {
            if (label.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetLabelText);
                label.Invoke(d, new object[] {label, coords});
            }
            else
            {
                var newText = Math.Round(coords, 1).ToString(CultureInfo.GetCultureInfo("de-DE"));
                label.ForeColor = label.Text == newText ? Color.Black : Color.Red;
                label.Text = newText;
                _canvas.Refresh();
            }
        }
    }
}