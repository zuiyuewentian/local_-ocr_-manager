using Drf_OCR_Manager_UI.Common;
using Drf_OCR_Manager_UI.Model;
using Drf_OCR_Manager_UI.SysControls;
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
    public partial class MainForm : MetroForm
    {
        ConfigModel configModel = new ConfigModel();
        public static UserInfoModel userInfoModel = null;
        public static bool IsResiger = false;//是否注册
                                             // public static bool IsResiger = true;//是否注册

        ImageOCR imageOCRForm = null;
        ErrorInfo errorInfoForm = null;
        Config ConfigForm = null;
        BatchImageOCR BatchImageOCRForm = null;
        PDFOCR PDFOCRForm = null;
        BatchPDFOCR BatchPDFOCRForm = null;
        about aboutForm = null;
        register registerForm = null;

        public MainForm()
        {
            InitializeComponent();

            this.Width = 1400;
            this.Height = 850;
            InitConfig();
            //InitSecKey();
            TestDemo();
        }

        private void TestDemo()
        {
            string config_path = Environment.CurrentDirectory + "\\tsys.kem";
            bool isEx = File.Exists(config_path);
            if (isEx)
            {
                string keyStr = File.ReadAllText(config_path);
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<TestDemoModel>(keyStr);
                if (data.uuid != GetComputerUUID.GetUUID())
                {
                    CheckSysForm checkSysForm = new CheckSysForm();
                    checkSysForm.ShowDialog();
                    IsResiger = false;
                }
                string pd_str = DESHelper.DecryptDES(data.pwd);
                int v;
                if (int.TryParse(pd_str, out v))
                {
                    if (v >= 21310 && v <= 21410)
                    {
                        IsResiger = true;
                    }
                    else
                    {
                        CheckSysForm checkSysForm = new CheckSysForm();
                        checkSysForm.ShowDialog();
                        IsResiger = false;
                    }
                }
            }
            else
            {
                CheckSysForm checkSysForm = new CheckSysForm();
                checkSysForm.ShowDialog();
                IsResiger = false;
            }
        }

        /// <summary>
        /// 加载密钥
        /// </summary>
        private void InitSecKey()
        {
            try
            {
                string config_path = Environment.CurrentDirectory + "\\sys.kem";
                bool isEx = File.Exists(config_path);
                if (isEx)
                {
                    string keyStr = File.ReadAllText(config_path);
                    userInfoModel = CheckUserHelper.CheckUser(keyStr.Trim());
                    userInfoModel.m_data = keyStr.Trim();

                    DateTime dateEnd = DateTime.Parse(userInfoModel.s_expire).Date;
                    if (dateEnd <= NetTimeHelper.GetTime())
                    {
                        lab_register.Text = "激活码已经到期";
                        metroTile5.Text = "未注册正版";
                        IsResiger = false;
                    }
                    else
                    {
                        lab_register.Text = userInfoModel.s_form + "V" + userInfoModel.s_version;
                        metroTile5.Text = "已经注册正版";
                        IsResiger = true;
                    }
                }
                else
                {
                    lab_register.Text = "注册正版入口";
                    metroTile5.Text = "未注册正版";
                    IsResiger = false;
                }
            }
            catch (Exception ex)
            {
                lab_register.Text = "注册正版入口";
                metroTile5.Text = "未注册正版";
                IsResiger = false;

                log4netHelper.Error("---报错方法--InitSecKey");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                MessageBox.Show("加载系统项失败！");
                Application.Exit();
            }

        }

        public void InitConfig()
        {
            try
            {
                string config_path = Environment.CurrentDirectory + "\\Config.json";
                bool isEx = File.Exists(config_path);
                if (isEx)
                {
                    var json = File.ReadAllText(config_path);
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(json);
                    configModel = data;

                    imageOCRForm = new ImageOCR(configModel, this);
                    imageOCRForm.Name = "imageOCRForm";
                    ChangeForm(imageOCRForm);
                }
                else
                {
                    errorInfoForm = new ErrorInfo();
                    errorInfoForm.Name = "errorInfoForm";
                    ChangeForm(errorInfoForm);
                }
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--InitConfig");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
        }

        /// <summary>
        /// 重写加载配置
        /// </summary>
        public void ReInitConfig()
        {
            try
            {
                string config_path = Environment.CurrentDirectory + "\\Config.json";
                bool isEx = File.Exists(config_path);
                if (isEx)
                {
                    var json = File.ReadAllText(config_path);
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(json);
                    configModel = data;
                }
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--ReInitConfig");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                metroTile_ocr.Enabled = IsResiger;
                metroTile_PDF.Enabled = IsResiger;
                metroTile_BatchImage.Enabled = IsResiger;
                metroTile_batchOcr.Enabled = IsResiger;
                metroTile_Config.Enabled = IsResiger;

                HotKey.RegisterHotKey(Handle, 104, HotKey.KeyModifiers.None, Keys.F4);
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--MainForm_Load");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private void metroTile_Config_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(() =>
                {
                    this.Invoke((EventHandler)delegate
                    {
                        ConfigForm = new Config(this);
                        ConfigForm.Name = "ConfigForm";
                        ChangeForm(ConfigForm);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_Config_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
        }

        private void metroTile_ocr_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(() =>
                {
                    this.Invoke((EventHandler)delegate
                    {
                        imageOCRForm = new ImageOCR(configModel, this);
                        imageOCRForm.Name = "imageOCRForm";
                        ChangeForm(imageOCRForm);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_ocr_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
        }

        /// <summary>
        /// 切换界面
        /// </summary>
        /// <param name="name"></param>
        private void ChangeForm(Control controlForm)
        {
            try
            {
                //清空界面
                panel_Main.Controls.Clear();
                if (controlForm.Name != "imageOCRForm")
                {
                    imageOCRForm = null;
                }


                controlForm.Width = panel_Main.Width;
                controlForm.Height = panel_Main.Height;
                controlForm.Dock = DockStyle.Fill;
                panel_Main.Controls.Add(controlForm);
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--ChangeForm");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                const int WM_HOTKEY = 0x0312;
                //按快捷键    
                switch (m.Msg)
                {
                    case WM_HOTKEY:
                        switch (m.WParam.ToInt32())
                        {
                            case 104:
                                if (imageOCRForm != null)
                                    imageOCRForm.CutPicture();
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
            }
            base.WndProc(ref m);
        }

        private void metroTile_BatchImage_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(() =>
                {
                    this.Invoke((EventHandler)delegate
                    {
                        BatchImageOCRForm = new BatchImageOCR(configModel, this);
                        BatchImageOCRForm.Name = "BatchImageOCRForm";
                        ChangeForm(BatchImageOCRForm);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_BatchImage_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private void metroTile_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(() =>
                {
                    this.Invoke((EventHandler)delegate
                    {
                        PDFOCRForm = new PDFOCR(configModel, this);
                        PDFOCRForm.Name = "PDFOCRForm";
                        ChangeForm(PDFOCRForm);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_PDF_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private void metroTile_batchOcr_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(() =>
                {
                    this.Invoke((EventHandler)delegate
                    {
                        BatchPDFOCRForm = new BatchPDFOCR(configModel, this);
                        BatchPDFOCRForm.Name = "BatchPDFOCRForm";
                        ChangeForm(BatchPDFOCRForm);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_batchOcr_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }


        }

        private void metroTile_about_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(() =>
                {
                    this.Invoke((EventHandler)delegate
                    {
                        aboutForm = new about();
                        aboutForm.Name = "aboutForm";
                        ChangeForm(aboutForm);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_about_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Reg_Sys();
        }

        /// <summary>
        /// 注册系统
        /// </summary>
        private void Reg_Sys()
        {
            try
            {
                Task task = new Task(() =>
                {
                    this.Invoke((EventHandler)delegate
                    {
                        registerForm = new register();
                        registerForm.Name = "registerForm";
                        ChangeForm(registerForm);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--Reg_Sys");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private void lab_register_Click(object sender, EventArgs e)
        {
            Reg_Sys();
        }
    }
}
