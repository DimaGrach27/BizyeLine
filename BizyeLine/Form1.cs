using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizyeLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void BizyeLine(float p0_x, float p0_y, float p1_x, float p1_y, float p2_x, float p2_y,float p3_x, float p3_y, Graphics e)
        {
            float t;
            Pen pen = new Pen(Color.Red);

            for (t = 0; t < 1.001f; t += 0.001f) 
            {
                //float xLine = (1 - t) * (1 - t) * p0_x + 2 * t * (1 - t) * p1_x + t * t * p2_x;
                //float yLine = (1 - t) * (1 - t) * p0_y + 2 * t * (1 - t) * p1_y + t * t * p2_y;
                float xLine = (1 - t) * (1 - t) * (1 - t) * p0_x + 3 * t * (1 - t) * (1 - t) * p1_x + 3 * t * t * (1 - t) * p2_x + t * t * t * p3_x;
                float yLine = (1 - t) * (1 - t) * (1 - t) * p0_y + 3 * t * (1 - t) * (1 - t) * p1_y + 3 * t * t * (1 - t) * p2_y + t * t * t * p3_y;
                
                e.DrawLine(pen, xLine, yLine, xLine + 0.3f, yLine + 0.3f);
            }          
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            BizyeLine(100, 150, 190, 113, 190, 113, 93, 270, e.Graphics);
            BizyeLine(100, 150, 10, 113, 10, 113, 93, 270, e.Graphics);

            //e.Graphics.DrawBezier(new Pen(Color.Black), 100, 150, 10, 113, 10, 113, 93, 270);
        }
    }
}
