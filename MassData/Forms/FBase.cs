using MassData.Classes;
using MassData.Properties;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MassData
{
    public partial class FBase : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int CS_DROPSHADOW = 0x20000;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private int NormalWidth;
        private int NormalHeight;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public FBase()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            LoadColorsAndResources();
        }

        private void LoadColorsAndResources()
        {
            //Colors
            pnlTitle.BackColor = CustomColors.PrimaryDarkColor;

            //Images
            btnClose.Image = Resources.close_28px_light;
            btnMaximize.Image = Resources.maximize_28px_light;
            btnMinimize.Image = Resources.minimize_28px_light;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = CustomColors.CloseOrErrorColor;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = CustomColors.PrimaryDarkColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Resources.restore_28px_light;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.Image = Resources.maximize_28px_light;
            }
        }

        private void FMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FMain_Shown(object sender, EventArgs e)
        {
            NormalWidth = Size.Width;
            NormalHeight = Size.Height;
        }

        private void FMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Size = new System.Drawing.Size(NormalWidth, NormalHeight);
            }
        }

    }
}
