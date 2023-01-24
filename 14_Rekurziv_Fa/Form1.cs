using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Rekurziv_Fa
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        Graphics g;
        SolidBrush brushCyan = new SolidBrush(Color.Cyan);
        SolidBrush brushGreen = new SolidBrush(Color.Green);
        static int recDepth = 5;
        static int leftBranchAngle = 315 + GetRandomNumberBranchAngle();
        static int rightBranchAngle = 45 + GetRandomNumberBranchAngle();

        public static double GetRandomNumberBranchLength()
        {
            double min = 1.7;
            double max = 2.0;
            return rnd.NextDouble() * (max - min) + min;
        }

        public static int GetRandomNumberBranchAngle()
        {
            int min = -5;
            int max = 5;
            return rnd.Next(min, max);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private PointF DrawSection(PointF startPoint, double angle_raw, double length, Pen pen)
        {
            angle_raw -= 90;
            double angle = (Math.PI / 180.0) * angle_raw;
            double startX = startPoint.X;
            double startY = startPoint.Y;
            double stopX = startX + (Math.Cos(angle) * length);
            double stopY = startY + (Math.Sin(angle) * length);

            PointF p1 = new PointF((float)startX, (float)startY);
            PointF p2 = new PointF((float)stopX, (float)stopY);

            g.DrawLine(pen, p1, p2);
            return p2;
        }

        private void DrawTree(int n, PointF startPoint, double angle, double length)
        {
            if (n > 0)
            {
                //1. lépés, csak a törzs
                PointF prevBranchEndPoint = DrawSection(startPoint, angle, length, new Pen(Brushes.Brown, n));
                //2. lépés, ágak
                PointF branchesStart = new PointF((float)(startPoint.X + prevBranchEndPoint.X) / 2, (float)(startPoint.Y + prevBranchEndPoint.Y) / 2);

                DrawSection(branchesStart, angle + leftBranchAngle, length / GetRandomNumberBranchLength() + 2, new Pen(Brushes.Green, n));
                DrawSection(branchesStart, angle + rightBranchAngle, length / GetRandomNumberBranchLength() + 2, new Pen(Brushes.Green, n));
                DrawSection(prevBranchEndPoint, angle, length / GetRandomNumberBranchLength(), new Pen(Brushes.Green, n));

                //3. lépés, rekurzió
                DrawTree(n - 1, prevBranchEndPoint, angle, length / GetRandomNumberBranchLength());
                DrawTree(n - 1, branchesStart, angle + leftBranchAngle, length / GetRandomNumberBranchLength());
                DrawTree(n - 1, branchesStart, angle + rightBranchAngle, length / GetRandomNumberBranchLength());
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.FillRectangle(brushCyan, new Rectangle(0, 0, canvas.Width, canvas.Height - 30));
            g.FillRectangle(brushGreen, new Rectangle(0, canvas.Height - 30, canvas.Width, canvas.Height - 30));

            PointF start = new PointF(canvas.Width / 2, canvas.Height - 20);
            DrawTree(recDepth, start, 0, 220);
        }

        private void scr_depth_ValueChanged(object sender, EventArgs e)
        {
            recDepth = scr_depth.Value;
            lbl_depth_value.Text = recDepth.ToString();
            canvas.Refresh();
        }        
    }
}
