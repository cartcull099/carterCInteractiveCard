using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

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
            /*When card is clicked, screen is cleared to green, happy birthday cheer is played,
             * text appears line by line, 4 balloons appear one by one with sounds*/

            //clearing name label 
            nameLabel.Visible = false;

            //setting up graphics and sounds
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Pop_sound);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.Birthday_sounds);
            
            //Changing background to green
            g.Clear(Color.Green);
            player2.Play();

            //Displaying "Happy" "Birthday"... (colour changes for each line)
            Font drawFont = new Font("Bell Gothic Std", 65, FontStyle.Bold);
            g.DrawString("Happy", drawFont, drawBrush, Width/2-150, Height/2-100);
            Thread.Sleep(1000);

            drawBrush.Color = Color.Blue;
            g.DrawString("Birthday", drawFont, drawBrush, Width / 2 - 200, Height / 2 );
            Thread.Sleep(1000);

            drawBrush.Color = Color.Yellow;
            g.DrawString("Have a great day!!!", drawFont, drawBrush, Width / 2-380 , Height / 2+100);
            Thread.Sleep(3500);

            //Baloons appear with pop sound
            player.Play();
            drawBrush.Color = Color.Red;
            g.FillEllipse(drawBrush, 100, 100, 75, 100);
            g.DrawLine(drawPen, 135, 300, 135, 200);
            Thread.Sleep(1000);

            player.Play();
            drawBrush.Color = Color.Yellow;
            g.FillEllipse(drawBrush, 20, 100, 75, 100);
            g.DrawLine(drawPen, 55, 300, 55, 200);
            Thread.Sleep(1000);

            player.Play();
            drawBrush.Color = Color.Red;
            g.FillEllipse(drawBrush, 550, 100, 75, 100);
            g.DrawLine(drawPen, 585, 300, 585, 200);
            Thread.Sleep(1000);

            player.Play();
            drawBrush.Color = Color.Yellow;
            g.FillEllipse(drawBrush, 630, 100, 75, 100);
            g.DrawLine(drawPen, 665, 300,665 , 200);
            Thread.Sleep(1000);




        }
    }
}
