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
        private void MoveCar(int spaces, int xAxis, int yAxiz)
        {
            for (int iter = 0; iter < spaces; iter++)
            {
                pictureBox1.Location = new Point(pictureBox1.Left + xAxis, pictureBox1.Top + yAxiz);
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
        }
        private void CarMove()
        {
            MoveCar(250, 1, 0);
            CheckLight();
            MoveCar(250, 1, 0);
            MoveCar(500,0,1);
            MoveCar(500, -1, 0);
            MoveCar(500, 0, -1);
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
