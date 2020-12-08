using MassData.Views.Classes;
using MassData.Views.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MassData.Views.Forms
{
    public partial class FMain : FBase
    {
        private int olderHeight;
        private int olderWidth;
        public FMain()
        {
            InitializeComponent();
        }

        internal void SetLayouts(DataTable data)
        {
            dgvLayouts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14);
            dgvLayouts.DataSource = data;
            dgvLayouts.Columns[0].HeaderText = "Id";
            dgvLayouts.Columns[1].HeaderText = "Nome";
            dgvLayouts.Columns[2].Visible = false;
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
            btnNew.Image = Resources.new_24px;
            btnEdit.Image = Resources.edit_24px;
            btnDel.Image = Resources.del_24px;
            btnSearch.Image = Resources.search_24px;
        }

        private void FMain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, CustomColors.PrimaryDarkColor, ButtonBorderStyle.Solid);
        }

        private void shadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvLayouts_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = btnDel.Enabled = (dgvLayouts.SelectedRows.Count > 0);
        }

        private void FMain_Resize(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.GetWorkingArea(this);
            if (Size.Height > 28)
            {
                ResizePanels();
                Refresh();
                olderHeight = Size.Height;
                olderWidth = Size.Width;
            }
        }

        private void ResizePanels()
        {
            if (olderHeight > 0 && olderWidth > 0)
            {
                spnlLayouts.Height += (Size.Height - olderHeight);
                spnlForms.Height += (Size.Height - olderHeight);
                spnlForms.Width += (Size.Width - olderWidth);
            }
        }

        private void FMain_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
            Activate();
        }
    }
}
