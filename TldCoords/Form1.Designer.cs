namespace TldCoords
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _watcher.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblXReal = new System.Windows.Forms.Label();
            this.LblYReal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.LblZReal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblX
            // 
            this.LblX.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblX.Location = new System.Drawing.Point(0, 20);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(110, 40);
            this.LblX.TabIndex = 0;
            this.LblX.Text = "000";
            this.LblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblXReal
            // 
            this.LblXReal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblXReal.Location = new System.Drawing.Point(0, 60);
            this.LblXReal.Name = "LblXReal";
            this.LblXReal.Size = new System.Drawing.Size(100, 20);
            this.LblXReal.TabIndex = 2;
            this.LblXReal.Text = "X";
            this.LblXReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblYReal
            // 
            this.LblYReal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblYReal.Location = new System.Drawing.Point(116, 60);
            this.LblYReal.Name = "LblYReal";
            this.LblYReal.Size = new System.Drawing.Size(100, 20);
            this.LblYReal.TabIndex = 5;
            this.LblYReal.Text = "Y";
            this.LblYReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(116, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblY
            // 
            this.LblY.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblY.Location = new System.Drawing.Point(116, 20);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(110, 40);
            this.LblY.TabIndex = 3;
            this.LblY.Text = "000";
            this.LblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblZReal
            // 
            this.LblZReal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblZReal.Location = new System.Drawing.Point(232, 60);
            this.LblZReal.Name = "LblZReal";
            this.LblZReal.Size = new System.Drawing.Size(100, 20);
            this.LblZReal.TabIndex = 8;
            this.LblZReal.Text = "Z";
            this.LblZReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(232, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Z";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblZ
            // 
            this.LblZ.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblZ.Location = new System.Drawing.Point(232, 20);
            this.LblZ.Name = "LblZ";
            this.LblZ.Size = new System.Drawing.Size(110, 40);
            this.LblZ.TabIndex = 6;
            this.LblZ.Text = "000";
            this.LblZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 85);
            this.Controls.Add(this.LblZReal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblZ);
            this.Controls.Add(this.LblYReal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblXReal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LblYReal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblZReal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Label LblZ;

        private System.Windows.Forms.Label LblXReal;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label LblX;

        #endregion
    }
}