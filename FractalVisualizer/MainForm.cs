using System;
using System.Drawing;
using System.Windows.Forms;
using static Fractals.Sierpinski;
using static Fractals.Divergent;
using Fractals;
using System.Linq;
using System.Collections.Generic;

namespace FractalVisualizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            color1TextBox.Text = Color.Red.ToArgb().ToString();
            color2TextBox.Text = color1TextBox.Text;
            levelNumUpDown.ValueChanged += (sender, e) => panel.Refresh();
            panel.Resize += (sender, e) => panel.Refresh();
            panel.Paint += Panel_Paint;

            fractalComboBox.Items.AddRange(new[] { "Mandelbrot", "c = -0.75, SanMarco", "c = -0.391-0.587i, SiegelDisk", "c = -0.123+0.745i, DouadyRabbit", "c = -0.835-0.2321i", "c = -0.70176-0.3842i" });
            fractalComboBox.SelectedIndex = 0;
            fractalComboBox.SelectedIndexChanged += (sender, e) => panel.Refresh();
            tabControl.Selected += (sender, e) => panel.Refresh();
            redNumericUpDown.Value = 9;
            greenNumericUpDown.Value = 11;
            blueNumericUpDown.Value = 20;
            redNumericUpDown.ValueChanged += (sender, e) => panel.Refresh();
            greenNumericUpDown.ValueChanged += (sender, e) => panel.Refresh();
            blueNumericUpDown.ValueChanged += (sender, e) => panel.Refresh();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            if (tabControl.SelectedIndex == 0)
                DrawSierpinski(e);
            else if (tabControl.SelectedIndex == 1)
                DrawDivergentFractal(e);
        }

        void DrawSierpinski(PaintEventArgs e)
        {
            const int GAP = 10;
            int side = SierpinskiUtil.GetTriangleOptimalSide(panel.ClientRectangle.Width, panel.ClientRectangle.Height, GAP);
            var tris = SierpinskiTriangle(
                new CartPoint((panel.ClientRectangle.Width - side) / 2, GAP),
                side,
                (int)levelNumUpDown.Value);

            Pen pen1 = new Pen(Color.FromArgb(int.Parse(color1TextBox.Text)));
            Pen pen2 = new Pen(Color.FromArgb(int.Parse(color2TextBox.Text)));
            Pen pen = pen1;
            foreach (var t in tris)
            {
                var tri = SierpinskiUtil.CartToScrCoords(t, panel.ClientRectangle.Height);
                var p1 = new Point(tri.p1.x, tri.p1.y);
                var p2 = new Point(tri.p2.x, tri.p2.y);
                var p3 = new Point(tri.p3.x, tri.p3.y);
                e.Graphics.DrawLine(pen, p1, p2);
                e.Graphics.DrawLine(pen, p2, p3);
                e.Graphics.DrawLine(pen, p3, p1);

                pen = pen == pen1 ? pen2 : pen1;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (sender == color1Button)
                        color1TextBox.Text = dlg.Color.ToArgb().ToString();
                    else
                        color2TextBox.Text = dlg.Color.ToArgb().ToString();
                    panel.Refresh();
                }
            }
        }

        void DrawDivergentFractal(PaintEventArgs e)
        {
            int w = panel.ClientRectangle.Width, h = panel.ClientRectangle.Height;

            IEnumerable<Tuple<int, int, int>> ts = null;
            switch (fractalComboBox.SelectedIndex)
            {
                case 1:
                    ts = SanMarco(w, h);
                    break;
                case 2:
                    ts = SiegelDisk(w, h);
                    break;
                case 3:
                    ts = DouadyRabbit(w, h);
                    break;
                case 4:
                    ts = JuliaVar1(w, h);
                    break;
                case 5:
                    ts = JuliaVar2(w, h);
                    break;
                default:
                    ts = MandelbrotEasy(w, h);
                    break;
            }

            ts = ts.Where(t => t.Item3 != 0 && t.Item3 != 1); //Minimize the no of pixels to be drawn.

            foreach (var t in ts)
            {
                int x = t.Item1, y = t.Item2, diverge = t.Item3;
                int r = (int)redNumericUpDown.Value, g = (int)greenNumericUpDown.Value, b = (int)blueNumericUpDown.Value;
                Color c = Color.FromArgb(Math.Min(diverge * r, 255), Math.Min(diverge * g, 255), Math.Min(diverge * b, 255));                
                e.Graphics.FillRectangle(new SolidBrush(c), x, y, 1, 1);
            }
        }
    }
}
