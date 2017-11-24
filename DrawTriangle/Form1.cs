using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt16(xBox1.Text);
            int x2 = Convert.ToInt16(xBox2.Text);
            int x3 = Convert.ToInt16(xBox3.Text);
            int y1 = Convert.ToInt16(yBox1.Text);
            int y2 = Convert.ToInt16(yBox2.Text);
            int y3 = Convert.ToInt16(yBox3.Text);

            Pen pen = new Pen(Color.Red, 1);

            DrawTriangle(pen, x1, y1, x2, y2, x3, y3);
        }

        //Draw Triangle Method
        public void DrawTriangle(Pen pen, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Graphics g = this.CreateGraphics();

            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x1, y1);
        }

        
    }
}
