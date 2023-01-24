using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Sierpinski_Haromszog
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = Pens.Red;

        PointF P0, P1, P2;
        
        public Form1()
        {
            InitializeComponent();
            P0 = new PointF(canvas.Width / 2, 30);
            P1 = new PointF(30, canvas.Height - 30);
            P2 = new PointF(canvas.Width - 30, canvas.Height - 30);
        }

        private void DrawSierpinski(PointF P0, PointF P1, PointF P2, int szint)
        {
            if (szint == 1)
            {
                g.DrawLine(p, P0, P1);
                g.DrawLine(p, P1, P2);
                g.DrawLine(p, P2, P0);
            }
            else
            {
                PointF PF0 = new PointF((P0.X + P1.X) / 2, ((P0.Y + P1.Y) / 2));
                PointF PF1 = new PointF((P1.X + P2.X) / 2, ((P1.Y + P2.Y) / 2));
                PointF PF2 = new PointF((P2.X + P0.X) / 2, ((P2.Y + P0.Y) / 2));
                DrawSierpinski(P0, PF0, PF2, szint - 1);
                DrawSierpinski(PF0, P1, PF1, szint - 1);
                DrawSierpinski(PF2, PF1, P2, szint - 1);
                //DrawSierpinski(PF0, PF2, PF1, szint - 1);   //a háromszögek közepe
            }
        }

        private void scrollBar_ValueChanged(object sender, EventArgs e)
        {
            lbl_szint.Text = scrollBar.Value.ToString();
            canvas.Refresh();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //g.DrawLine(new Pen(Color.Black, 3f), 10, 34, 123, 356);   //csak firka
            DrawSierpinski(P0, P1, P2, scrollBar.Value);
        }
    }
}
