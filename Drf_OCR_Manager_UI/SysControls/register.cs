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
using System.IO;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();

            BindKey();
        }

        private void BindKey()
        {
            try
            {
                if (MainForm.IsResiger)
                {
                    register_text1.Info_text = "****************************";
                    DateTime dateEnd = DateTime.Parse(MainForm.userInfoModel.s_expire).Date;
                    DateTime dateStart = DateTime.Parse(MainForm.userInfoModel.s_create).Date;
                    int year = dateEnd.Year - dateStart.Year;
                    string yearText = year + "年";
                    if (year >= 100)
                    {
                        yearText = "永远";
                    }
                    version_select1.Info_text = MainForm.userInfoModel.s_form;
                    version_select4.Info_text = yearText;
                    label4.Text = "截止：" + dateEnd.ToString("yyyy-MM-dd");
                    metroTile_Resiger.Enabled = false;
                }

                pic_version.Visible = MainForm.IsResiger;
                lab_version.Visible = MainForm.IsResiger;
                lab_version.Refresh();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--BindKey");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
        }

        private void metroTile_buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dongrufeng.com");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dongrufeng.com/buy?invite_id=" + GetComputerUUID.GetUUID());
        }

        private void metroTile_Resiger_Click(object sender, EventArgs e)
        {
            try
            {
                string text = register_text1.Info_text.Trim();
                var user = CheckUserHelper.CheckUser(text);
                if (user == null)
                {
                    MessageBox.Show("激活失败！");
                    return;
                }
                DateTime dateEnd = DateTime.Parse(user.s_expire).Date;
                if (dateEnd <= DateTime.Now)
                {
                    MessageBox.Show("激活失败,激活码已经到期");
                    return;
                }
                File.WriteAllText("sys.kem", text.Trim());
                MainForm.userInfoModel = user;
                MainForm.IsResiger = true;
                MessageBox.Show("激活成功！");
                BindKey();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_Resiger_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                MessageBox.Show("激活失败！"+ex.Message);
            }
        }
    }
}
