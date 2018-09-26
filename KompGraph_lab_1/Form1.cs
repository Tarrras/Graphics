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

namespace KompGraph_lab_1
{
    public partial class Form1 : Form
    {
        Graphics gr,car;
        Pen pen,car_Pen;
        SolidBrush solidBrush,car_Brush;
        Random rnd;
        int rad;

       
       
        

        public Form1()
        {
            InitializeComponent();
           
        }

        void DrawCircle(int x, int y)
        {
            int xc, yc;
            xc = x - rad;
            yc = y - rad;
            gr.FillEllipse(solidBrush, xc, yc, rad, rad);
            gr.DrawEllipse(pen, xc, yc, rad, rad);


        }

        

        private void start_Button_Click(object sender, EventArgs e)
        {
            
            gr = pictureBox1.CreateGraphics();
            pen = new Pen(Color.DarkGoldenrod);
            solidBrush = new SolidBrush(Color.LemonChiffon);
            rad = 30;
            rnd = new Random();
            int x, y;
            for(int i = 0; i < 10; i++)
            {
                x = rnd.Next(pictureBox1.Width);
                y = rnd.Next(pictureBox1.Height);
                DrawCircle(x, y);
                
            }
            timer1.Enabled = true;
        

        }

        private void bird_Release_Click(object sender, EventArgs e)
        {
            car = pictureBox1.CreateGraphics();
            car_Pen = new Pen(Color.Black, 3);
            car_Brush = new SolidBrush(Color.RoyalBlue);
            Pen p = new Pen(Color.Brown, 5);


            while (true)
            {
                
                for ( int i = pictureBox1.Left; i < pictureBox1.Right - 100; i++)
                {

                   
                        car.DrawLine(p, 131 + i, 300, 150 + i, 250);
                        car.DrawRectangle(car_Pen, 30 + i, 300, 100, 50);
                        car.FillRectangle(car_Brush, 30 + i, 300, 100, 50);
                        car.DrawRectangle(car_Pen, 30 + i, 235, 50, 65);
                        car.FillRectangle(car_Brush, 30 + i, 235, 50, 65);
                        car.DrawEllipse(new Pen(Color.Black, 2), 30 + i, 350, 30, 30);
                        car.FillEllipse(new SolidBrush(Color.Salmon), 30 + i, 350, 30, 30);
                        car.DrawEllipse(new Pen(Color.Black, 2), 100 + i, 350, 30, 30);
                        car.FillEllipse(new SolidBrush(Color.Salmon), 100 + i, 350, 30, 30);
                       
                        

                    if (i == pictureBox1.Right - 150)
                    {
                        car.DrawLine(p, 131 + i, 300, 150 + i, 250);
                        car.DrawRectangle(car_Pen, 30 + i, 300, 100, 50);
                        car.FillRectangle(car_Brush, 30 + i, 300, 100, 50);
                        car.DrawRectangle(car_Pen, 30 + i, 235, 50, 65);
                        car.FillRectangle(car_Brush, 30 + i, 235, 50, 65);
                        car.DrawEllipse(new Pen(Color.Black, 2), 30 + i, 350, 30, 30);
                        car.FillEllipse(new SolidBrush(Color.Salmon), 30 + i, 350, 30, 30);
                        car.DrawEllipse(new Pen(Color.Black, 2), 100 + i, 350, 30, 30);
                        car.FillEllipse(new SolidBrush(Color.Salmon), 100 + i, 350, 30, 30);
                        Thread.Sleep(2);
                        car.Clear(Color.White);
                        /* for (int j = i; j > 0; j--)
                         {

                             car.DrawLine(p, 131 + j, 300, 150 + j, 250);
                             car.DrawRectangle(car_Pen, 30 + j, 300, 100, 50);
                             car.FillRectangle(car_Brush, 30 + j, 300, 100, 50);
                             car.DrawRectangle(car_Pen, 30 + j, 235, 50, 65);
                             car.FillRectangle(car_Brush, 30 + j, 235, 50, 65);
                             car.DrawEllipse(new Pen(Color.Black, 2), 30 + j, 350, 30, 30);
                             car.FillEllipse(new SolidBrush(Color.Salmon), 30 + j, 350, 30, 30);
                             car.DrawEllipse(new Pen(Color.Black, 2), 100 + j, 350, 30, 30);
                             car.FillEllipse(new SolidBrush(Color.Salmon), 100 + j, 350, 30, 30);
                             Thread.Sleep(2);

                             car.Clear(Color.White);
                         }*/

                    }
                    Thread.Sleep(2);
                    car.Clear(Color.White);

                }
            }
        }
                
     

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
            int x, y;
            for (int i = 0; i < 10; i++)
            {
                x = rnd.Next(pictureBox1.Width);
                y = rnd.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }
        }
        

    }
}
