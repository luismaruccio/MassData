using MassData.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MassData.Forms
{
    public partial class FMain : FBase
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void DropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            //pnlLayouts.Paint += DropShadow;
        }

        private void FMain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, CustomColors.PrimaryDarkColor, ButtonBorderStyle.Solid);
        }

        private void shadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
