using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OcrLiteLib;
using Drf_OCR_Manager_UI.Model;
using System.IO;
using Drf_OCR_Manager_UI.Common;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class BatchImageOCR : UserControl
    {
        ConfigModel configModel = new ConfigModel();
        private OcrLite ocrEngin;
        private MainForm T_MainForm;

        /// <summary>
        /// 输出文件夹
        /// </summary>
        private string out_url = Environment.CurrentDirectory + "\\texts\\";

        public List<string> imgList = new List<string>();

        public BatchImageOCR(ConfigModel config, MainForm form)
        {
            InitializeComponent();

            configModel = config;

            if (configModel.Out_Location == null)
            {
                out_url = Environment.CurrentDirectory + "\\texts\\";
            }
            else
            {
                if (configModel.Out_Location != "\\texts\\")
                {
                    out_url = configModel.Out_Location;
                }
                else
                {
                    out_url = Environment.CurrentDirectory + configModel.Out_Location;
                }
            }

            T_MainForm = form;
            waiting_Info.Visible = false;

            Init();

            if (!Directory.Exists(out_url))
            {
                Directory.CreateDirectory(out_url);
            }
        }

        private void Init()
        {
            try
            {
                ocrEngin = new OcrLite();

                string def_address = Environment.CurrentDirectory;
                ocrEngin.InitModels(
                    def_address + configModel.detPath,
                    def_address + configModel.clsPath,
                    def_address + configModel.recPath,
                    def_address + configModel.keysPath,
                    configModel.numThreadNumeric);
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--Init");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                MessageBox.Show("初始化异常");
            }
        }

        private void metroTile_select_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainForm.IsResiger)
                    return;

                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择待识别文件路径";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox_list.Clear();
                    richTextBox_text.Clear();

                    string url = dialog.SelectedPath;
                    imgList = Directory.GetFiles(url).ToList();
                    numInfo_read.setValue(imgList.Count());
                    int index = 1;
                    foreach (var item in imgList)
                    {
                        richTextBox_list.Text += "[" + index + "]." + item + Environment.NewLine;
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_select_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        /// <summary>
        /// 执行等待操作
        /// </summary>
        /// <param name="wait"></param>
        private void IsWait(bool wait)
        {
            this.Invoke((EventHandler)delegate
            {
                waiting_Info.Visible = wait;
                metroTile_select.Enabled = !wait;
                metroTile_Start.Enabled = !wait;
                metroTile_out.Enabled = !wait;
            });
        }

        private void metroTile_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainForm.IsResiger)
                    return;

                if (String.IsNullOrEmpty(richTextBox_list.Text))
                {
                    return;
                }
                DirectoryHelper.ClearFiles(out_url);
                IsWait(true);

                Task task = new Task(() =>
                {
                    int index = 1;
                    int sum = imgList.Count();
                    foreach (var item in imgList)
                    {
                        string name = Path.GetFileNameWithoutExtension(item);
                        string value = ocr(item, name);
                        this.Invoke((EventHandler)delegate
                        {
                            richTextBox_text.Text += "[" + index + "]" + value + Environment.NewLine;
                            string valueStr = index + "/" + sum;
                            waiting_Info.SetShowValue("系统正在识别中[" + valueStr + "],请稍等...");
                            numInfo_ocr.setValue(index);
                        });
                        index++;
                    }
                    IsWait(false);
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_Start_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private string ocr(string url, string name)
        {
            try
            {
                OcrResult ocrResult = ocrEngin.Detect(url,
                             configModel.padding,
                             configModel.imgResize,
                             configModel.boxScoreThresh,
                             configModel.boxThresh,
                             configModel.unClipRatio,
                             configModel.doAngle,
                             configModel.mostAngle);

                string res = ocrResult.StrRes;
                File.WriteAllText(out_url + name + ".txt", res);
                return name + ".txt";
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_Start_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                throw ex;
            }
        }

        private void metroTile_out_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(out_url))
                {
                    MessageBox.Show("不存在输出文件夹,请重新配置");
                    return;
                }
                System.Diagnostics.Process.Start("explorer.exe", out_url);
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_out_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }
    }
}
