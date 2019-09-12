using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
/// <summary>
/// Created by Eason
/// september 2019
/// PacMan
/// </summary>
namespace PacMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Object
            Graphics g = this.CreateGraphics();
            Pen tilePen = new Pen(Color.Black);
            Font titleFont = new Font("Courier New", 16);
            SolidBrush titlebrush = new SolidBrush(Color.Black);
            Pen PathPen = new Pen(Color.Blue, 10);

            //
            g.DrawString("Player 1 Get Ready", titleFont, titlebrush, 10, 50);
       




        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // new object
            Graphics g = this.CreateGraphics();
            Pen tilePen = new Pen(Color.Black);
            Font titleFont = new Font("Courier New", 16);
            SolidBrush Pacbrush = new SolidBrush(Color.Yellow);
            Pen PathPen = new Pen(Color.Blue, 10);
            //sound
            SoundPlayer beginsound = new SoundPlayer(Properties.Resources.begin);
            SoundPlayer Chompsound = new SoundPlayer(Properties.Resources.chomp);
            //
           

            //screen 
            g.Clear(Color.Black);
            //where sounds begin 
            beginsound.Play();
            Thread.Sleep(3000);
            Chompsound.Play();

            //the path
            g.DrawLine(PathPen, 0, 20, 270, 20);
            g.DrawLine(PathPen, 0, 80, 200, 80);
            g.DrawLine(PathPen, 270, 17, 270, 180);
            g.DrawLine(PathPen, 200, 77, 200, 180);
            //PacMan
            g.FillPie(Pacbrush, 0, 30, 40, 40, 30, 300);
            Thread.Sleep(1000);
            // Frame 2 
            g.Clear(Color.Black);
            g.FillPie(Pacbrush, 40, 30, 40, 40, 30, 360);
            g.DrawLine(PathPen, 0, 20, 270, 20);
            g.DrawLine(PathPen, 0, 80, 200, 80);
            g.DrawLine(PathPen, 270, 17, 270, 180);
            g.DrawLine(PathPen, 200, 77, 200, 180);
            Thread.Sleep(1000);

            //frame 3 
            g.Clear(Color.Black);
            g.FillPie(Pacbrush, 80, 30, 40, 40, 30, 300);
            g.DrawLine(PathPen, 0, 20, 270, 20);
            g.DrawLine(PathPen, 0, 80, 200, 80);
            g.DrawLine(PathPen, 270, 17, 270, 180);
            g.DrawLine(PathPen, 200, 77, 200, 180);
            Thread.Sleep(1000);


        }
    }
}
