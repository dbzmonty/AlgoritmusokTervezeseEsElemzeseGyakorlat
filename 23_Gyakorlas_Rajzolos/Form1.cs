using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_Gyakorlas_Rajzolos
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pencil = Pens.Black;
        PointF Origo;

        public Form1()
        {
            InitializeComponent();            
            Origo = new PointF(canvas.Width / 2, canvas.Height / 2);
        }

        private void DrawCircles(PointF startDraw, int level, float radius)
        {
            if (level == 1)
                g.DrawEllipse(pencil, startDraw.X - radius, startDraw.Y - radius, radius * 2, radius * 2);
            else
            {
                PointF P1 = new PointF(startDraw.X - radius, startDraw.Y - radius);
                PointF P2 = new PointF(startDraw.X + radius, startDraw.Y - radius);
                PointF P3 = new PointF(startDraw.X + radius, startDraw.Y + radius);
                PointF P4 = new PointF(startDraw.X - radius, startDraw.Y + radius);
                DrawCircles(P1, level - 1, radius / 3);
                DrawCircles(P2, level - 1, radius / 3);
                DrawCircles(P3, level - 1, radius / 3);
                DrawCircles(P4, level - 1, radius / 3);
            }
        }

        private void scr_level_ValueChanged(object sender, EventArgs e)
        {
            lbl_level.Text = scr_level.Value.ToString();
            canvas.Refresh();
        }
                
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;            
            for (int i = 1; i <= scr_level.Value; i++)
            {
                DrawCircles(Origo, i, 120);
            }
        }
    }
}
