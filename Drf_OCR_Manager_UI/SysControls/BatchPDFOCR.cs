using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drf_OCR_Manager_UI.Model;
using OcrLiteLib;
using Drf_OCR_Manager_UI.Common;
using System.IO;
using System.Threading;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class BatchPDFOCR : UserControl
    {
        ConfigModel configModel = new ConfigModel();
        private OcrLite ocrEngin;
        private MainForm T_MainForm;
        /// <summary>
        /// 正在拆分第几个pdf
        /// </summary>
        private int PageIndex = 1;

        /// <summary>
        /// 输出文件夹
        /// </summary>
        private string out_url = Environment.CurrentDirectory + "\\texts\\";

        /// <summary>
        /// 默认剪切图片保存地址
        /// </summary>
        private string tempPath = Environment.CurrentDirectory + "\\tempBatchImgs\\";

        public List<string> pdfList = new List<string>();

        public BatchPDFOCR(ConfigModel config, MainForm form)
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
            if (!Directory.Exists(tempPath))
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
            if (!MainForm.IsResiger)
                return;

            if (String.IsNullOrEmpty(richTextBox_list.Text))
            {
                return;
            }
            if (PageIndex <= 1)
                return;

            waiting_Info.SetShowValue("系统正在识别PDF中,请稍等...");

            try
            {
                DirectoryHelper.ClearFiles(out_url);
                IsWait(true);

                Task task = new Task(() =>
                {
                    int index = 1;
                    var imgFolderList = Directory.GetDirectories(tempPath);
                    foreach (var item in imgFolderList)
                    {

                        string folder_name = Path.GetFileNameWithoutExtension(item);
                        var imgList = Directory.GetFiles(item);
                        StringBuilder stringBuilder = new StringBuilder();
                        int mPageIndex = 1;
                        int sum = imgFolderList.Count();
                        foreach (var img_address in imgList)
                        {
                            string name = Path.GetFileNameWithoutExtension(item);
                            string value = ocr(img_address, name) + Environment.NewLine;
                            stringBuilder.Append(value);
                            this.Invoke((EventHandler)delegate
                            {
                                string valueStr = index + "/" + sum;
                                waiting_Info.SetShowValue("系统正在识别第" + index + "个PDF中[" + valueStr + "]页,请稍等...");
                            });
                            mPageIndex++;
                        }
                        this.Invoke((EventHandler)delegate
                        {
                            numInfo_ocr.setValue(index);
                            waiting_Info.SetShowValue("系统正在识别第" + index + "个PDF完成,请稍等...");
                            string address = out_url + folder_name + ".txt";
                            File.WriteAllText(address, stringBuilder.ToString());
                            richTextBox_text.Text += "[" + index + "]" + address + Environment.NewLine;
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
                return res;
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_out_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                return "";
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
                    pdfList = Directory.GetFiles(url).ToList();
                    numInfo_read.setValue(pdfList.Count());
                    int index = 1;
                    foreach (var item in pdfList)
                    {
                        richTextBox_list.Text += "[" + index + "]." + item + Environment.NewLine;
                        index++;
                    }
                    CutAllPdf();
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

        private void CutAllPdf()
        {
            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }
            else
            {
                DirectoryHelper.ClearFiles(tempPath);
            }

            CutPdfHelper.ChangeEvent += CutPdfHelper_ChangeEvent;

            IsWait(true);
            waiting_Info.SetShowValue("系统正在拆分PDF中,请稍等...");
            PageIndex = 1;

            try
            {
                Task task = new Task(() =>
                {
                    foreach (var item in pdfList)
                    {
                        string name = Path.GetFileNameWithoutExtension(item);
                        string folder = tempPath + name + "\\";
                        if (!Directory.Exists(folder))
                        {
                            Directory.CreateDirectory(folder);
                        }
                        CutPdfHelper.ConvertPDF2Image(item, folder, "");
                        PageIndex++;
                    }
                    IsWait(false);
                });
                task.Start();

            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--CutAllPdf");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        /// <summary>
        /// 拆分
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="sumCount"></param>
        /// <param name="imgName"></param>
        private void CutPdfHelper_ChangeEvent(int pageIndex, int sumCount, string name)
        {
            this.Invoke((EventHandler)delegate
            {
                string valueStr = pageIndex + "/" + sumCount;
                waiting_Info.SetShowValue("系统正在拆分第[" + PageIndex + "]个PDF的[" + valueStr + "]页,请稍等...");

            });
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
