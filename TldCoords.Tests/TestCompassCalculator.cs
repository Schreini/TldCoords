using System;
using Xunit;

namespace TldCoords.Tests
{
    public class TestCompassCalculator
    {
        [Fact]
        public void Test1()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 0, YReal = 0},
                new Koordinaten() {XReal = 50, YReal = 50});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(100, actual.To.X);
            Assert.Equal(100, actual.To.Y);
        }
        
        [Fact]
        public void Test2()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 0, YReal = 0},
                new Koordinaten() {XReal = 100, YReal = 100});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(100, actual.To.X);
            Assert.Equal(100, actual.To.Y);
        }

        [Fact]
        public void Test3()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 0, YReal = 0},
                new Koordinaten() {XReal = 100, YReal = 0});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(100, actual.To.X);
            Assert.Equal(50, actual.To.Y);
        }
        
        [Fact]
        public void Test4()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 0, YReal = 0},
                new Koordinaten() {XReal = 500, YReal = 0});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(100, actual.To.X);
            Assert.Equal(50, actual.To.Y);
        }
        
        [Fact]
        public void Test5()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 0, YReal = 0},
                new Koordinaten() {XReal = 200, YReal = 100});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(100, actual.To.X);
            Assert.Equal(75, actual.To.Y);
        }
        
        [Fact]
        public void Test6()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 100, YReal = 200},
                new Koordinaten() {XReal = 300, YReal = 300});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(100, actual.To.X);
            Assert.Equal(75, actual.To.Y);
        }

        [Fact]
        public void Test7()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 100, YReal = 100},
                new Koordinaten() {XReal = 0, YReal = 50});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(0, actual.To.X);
            Assert.Equal(25, actual.To.Y);
        }
        
        [Fact]
        public void Test8()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 100, YReal = 100},
                new Koordinaten() {XReal = 0, YReal = 0});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(0, actual.To.X);
            Assert.Equal(0, actual.To.Y);
        }
        
        [Fact]
        public void Test9()
        {
            //arange
            var target = new CompassCalculator();
            
            //act
            var actual = target.Calculate(new Koordinaten() {XReal = 100, YReal = 100},
                new Koordinaten() {XReal = 0, YReal = 1000});
            
            //assert
            Assert.Equal(50, actual.From.X);
            Assert.Equal(50, actual.From.Y);
            Assert.Equal(44, actual.To.X);
            Assert.Equal(100, actual.To.Y);
        }   
    }
}