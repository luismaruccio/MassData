using MassData.Views.Properties;
using System;
using System.Windows.Forms;

namespace MassData.Views.Forms
{
    public partial class FSplash : Form
    {
        private delegate void StageProgress(string stage);
        private StageProgress del;

        public FSplash()
        {
            InitializeComponent();
            del = this.UpdateStageInternal;
        }

        private void FSplash_Load(object sender, EventArgs e)
        {
            picbcLogo.Image = Resources.Logo_64px;
            picbxLoading.Image = Resources.Pulse_1s_200px;
            lblbStatus.Text = "Iniciando Recursos";
        }

        private void UpdateStageInternal(string stage)
        {
            if (this.Handle == null)
            {
                return;
            }
            this.lblbStatus.Text = stage;
        }

        public void UpdateStage(string stage)
        {
            this.Invoke(del, stage);
        }
    }
}
