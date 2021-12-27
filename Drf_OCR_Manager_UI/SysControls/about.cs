using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drf_OCR_Manager_UI.Common;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class about : UserControl
    {
        public about()
        {
            InitializeComponent();

            label_UUID.Text = GetComputerUUID.GetUUID();
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {
            int left_value = panel1.Width / 2 - label_version.Width / 2;
            label_version.Left = left_value;
            label_UUID.Left = left_value;
            label_qq.Left = left_value;
            label_address.Left = left_value;
            pic_erweima.Left = left_value;
        }

        private void label_copyuuid_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(label_UUID.Text.Trim());
        }

        private void label_qqstr_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(label_qq.Text.Trim());
        }

        private void lab_web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dongrufeng.com");
        }
    }
}
