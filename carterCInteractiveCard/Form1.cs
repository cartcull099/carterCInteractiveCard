using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace carterCInteractiveCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           }

        private void Form1_Click(object sender, EventArgs e)
        {
            nameLabel.Visible = false;

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.Clear(Color.Green);

            Font drawFont = new Font("Bell Gothic Std", 65, FontStyle.Bold);
            g.DrawString("Happy", drawFont, drawBrush, Width/2-150, Height/2-100);
            Thread.Sleep(1000);

            drawBrush.Color = Color.Blue;
            g.DrawString("Birthday", drawFont, drawBrush, Width / 2 - 200, Height / 2 );
            Thread.Sleep(1000);

            drawBrush.Color = Color.Yellow;
            g.DrawString("Have a great day!!!", drawFont, drawBrush, Width / 2-380 , Height / 2+100);
            Thread.Sleep(1000);

            drawBrush.Color = Color.Red;
            g.FillEllipse(drawBrush, 100, 100, 75, 100);
            g.DrawLine(drawPen, 135, 300, 135, 200);
            Thread.Sleep(1000);

            drawBrush.Color = Color.Yellow;
            g.FillEllipse(drawBrush, 50, 100, 75, 100);
            g.DrawLine(drawPen, 135, 300, 135, 200);
            Thread.Sleep(1000);





        }
    }
}
