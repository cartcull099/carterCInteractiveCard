using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carterCInteractiveCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 65, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.DrawString("Happy Birthday!", drawFont, drawBrush, 50, 40);


            ffjgfhghjgfgfhg
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
