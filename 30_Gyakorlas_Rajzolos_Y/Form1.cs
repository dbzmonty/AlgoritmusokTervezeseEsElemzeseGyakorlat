using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Gyakorlas_Rajzolos_Y
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = Pens.Black;
        PointF P;

        public Form1()
        {
            InitializeComponent();
            P = new PointF(Canvas.Width / 2, Canvas.Height / 2);
        }
        
        private void DrawY(PointF start, int level, float length)
        {
            PointF P1 = new PointF(start.X, start.Y - length);
            PointF P2 = new PointF(start.X + length, start.Y + length);
            PointF P3 = new PointF(start.X - length, start.Y + length);

            if (level == 1)
            {
                g.DrawLine(p, start, P1);
                g.DrawLine(p, start, P2);
                g.DrawLine(p, start, P3);
            }
            else
            {
                DrawY(P1, level - 1, length / 3);
                DrawY(P2, level - 1, length / 3);
                DrawY(P3, level - 1, length / 3);
            }
        }

        private void scr_level_ValueChanged(object sender, EventArgs e)
        {
            lbl_level.Text = scr_level.Value.ToString();
            Canvas.Refresh();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 1; i <= scr_level.Value; i++)
            {
                DrawY(P, i, 120);
            }
        }
    }
}
