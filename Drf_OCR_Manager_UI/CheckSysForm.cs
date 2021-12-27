using Drf_OCR_Manager_UI.Common;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drf_OCR_Manager_UI
{
    public partial class CheckSysForm : MetroForm
    {
        public CheckSysForm()
        {
            InitializeComponent();

            label_UUID.Text = GetComputerUUID.GetUUID();
        }

        private void metroTile_Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_outloc.Text.Trim()))
            {
                return;
            }

            string data = DESHelper.DecryptDES(tb_outloc.Text.Trim());
            int v;
            if (int.TryParse(data, out v))
            {
                if (v >= 21310 && v <= 21410)
                {
                    TestDemoModel testDemoModel = new TestDemoModel();
                    testDemoModel.pwd = tb_outloc.Text.Trim();
                    testDemoModel.uuid = label_UUID.Text;
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(testDemoModel);
                    File.WriteAllText("tsys.kem", json);
                    MessageBox.Show("校验成功");
                }
            }
            else
            {
                MessageBox.Show("校验失败");
                return;
            }

         

        }

        private void CheckSysForm_Load(object sender, EventArgs e)
        {

        }

        private void label_copyuuid_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(label_UUID.Text.Trim());
        }
    }
}
