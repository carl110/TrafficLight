using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        string[] trafficLight = { "Red", "Amber", "Green"};
        int lightNo = 1;
        public Form1()
        {
            InitializeComponent();
           pictureBox1.Location = new Point(100, 100);
        }
        private void ChangeLightColour()
        {
            if(lightNo == 1)
            {
                picTrafficLight.Image = Image.FromFile("ACircle.jpg");
                lightNo = 2;
            } else if (lightNo == 2)
            {
                picTrafficLight.Image = Image.FromFile("RedCircle.jpg");
                Application.DoEvents();
                lightNo = 3;
            }
            else if (lightNo == 3) 
            {
                picTrafficLight.Image = Image.FromFile("GreenCircle.jpg");
                lightNo = 1;
            }
        }
        private void CheckLight()
        {
            if (lightNo != 1)
            {
                System.Threading.Thread.Sleep(500);
                ChangeLightColour();
                CheckLight();
            }
        }
        private void CarMove()
        {
            for (int iter = 0; iter < 250; iter++)
            {
                pictureBox1.Location = new Point(pictureBox1.Left + 1, pictureBox1.Top);
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
                CheckLight();
            for (int iter = 0; iter < 250; iter++)
            {
                pictureBox1.Location = new Point(pictureBox1.Left + 1, pictureBox1.Top);
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
            for (int iter = 0; iter < 500; iter++)
            {
                pictureBox1.Location = new Point(pictureBox1.Left, pictureBox1.Top + 1);
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
            for (int iter = 0; iter < 500; iter++)
            {
                pictureBox1.Location = new Point(pictureBox1.Left - 1, pictureBox1.Top);
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
            for (int iter = 0; iter < 500; iter++)
            {
                pictureBox1.Location = new Point(pictureBox1.Left, pictureBox1.Top - 1);
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
            CarMove();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            CarMove();
        }
        private void btnTrafficLight_Click(object sender, EventArgs e)
        {
            ChangeLightColour();
        }
    }
}
