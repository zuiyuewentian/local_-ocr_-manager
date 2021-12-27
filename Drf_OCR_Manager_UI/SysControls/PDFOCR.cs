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
using Drf_OCR_Manager_UI.Common;
using System.IO;
using System.Threading;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class PDFOCR : UserControl
    {
        ConfigModel configModel = new ConfigModel();
        private OcrLite ocrEngin;
        private MainForm T_MainForm;

        /// <summary>
        /// 选中地址
        /// </summary>
        private string file_Address = null;

        /// <summary>
        /// 切分出来的总页数
        /// </summary>
        private int PageCount = 0;

        /// <summary>
        /// 默认剪切图片保存地址
        /// </summary>
        private string tempPath = Environment.CurrentDirectory + "\\tempImgs\\";

        /// <summary>
        /// 输出文件夹
        /// </summary>
        private string out_url = Environment.CurrentDirectory + "\\texts\\";

        public PDFOCR(ConfigModel config, MainForm form)
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
                metroTile_Select.Enabled = !wait;
                metroTile_Start.Enabled = !wait;
                metroTile_OutData.Enabled = !wait;
                metroTile_out.Enabled = !wait;
            });
        }

        private void metroTile_Select_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainForm.IsResiger)
                    return;

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Title = "请选择PDF";
                fileDialog.Filter = "所有文件(*pdf*)|*.pdf*"; //设置要选择的文件的类型
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;//返回文件的完整路径     
                    file_Address = file;
                    int pagesCount = CutPdfHelper.GetPdfPagesCount(file);
                    pdfNumInfo_Page.setValue(pagesCount);

                    CutPdf(file);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请选择正确的PDF");
            }
        }

        /// <summary>
        /// 开始上传并裁切
        /// </summary>
        private void CutPdf(string file)
        {
            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }
            else
            {
                DirectoryHelper.ClearFiles(tempPath);
            }
            try
            {
                CutPdfHelper.ChangeEvent += CutPdfHelper_ChangeEvent;

                waiting_Info.SetShowValue("系统正在拆分PDF中,请稍等...");
                IsWait(true);
                Task task = new Task(() =>
                {
                    CutPdfHelper.ConvertPDF2Image(file, tempPath, "");
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--CutPdf");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
        }

        private void CutPdfHelper_ChangeEvent(int pageIndex, int sumCount, string name)
        {
            try
            {
                this.Invoke((EventHandler)delegate
                {
                    string valueStr = pageIndex + "/" + sumCount;
                    waiting_Info.SetShowValue("系统正在拆分PDF中[" + valueStr + "],请稍等...");
                    if (pageIndex == 1)
                    {
                        string address = tempPath + name;
                        Thread.Sleep(1000);
                        try
                        {
                            using (FileStream lStream = new FileStream(address, FileMode.Open, FileAccess.Read))
                            {
                                pic_Image.Image = Image.FromStream(lStream);
                            }
                        }
                        catch (Exception ex)
                        {
                            log4netHelper.Error("---报错方法--CutPdfHelper_ChangeEvent");
                            log4netHelper.Error("---报错方法--pic_Image");
                            log4netHelper.Error(ex.Message);
                            log4netHelper.Error(ex.StackTrace);
                            log4netHelper.Error(ex.ToString());
                            log4netHelper.Error("---end---");
                        }
                       
                    }
                    if (pageIndex >= sumCount)
                    {
                        IsWait(false);
                        PageCount = sumCount;
                    }
                });
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--CutPdfHelper_ChangeEvent");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private void metroTile_Start_Click(object sender, EventArgs e)
        {
            if (!MainForm.IsResiger)
                return;

            if (PageCount <= 0)
            {
                return;
            }
            try
            {
                waiting_Info.SetShowValue("系统正在识别PDF中,请稍等...");

                DirectoryHelper.ClearFiles(out_url);
                IsWait(true);

                Task task = new Task(() =>
                {
                    int index = 1;
                    var imgList = Directory.GetFiles(tempPath);
                    int sum = imgList.Count();
                    foreach (var item in imgList)
                    {
                        string name = Path.GetFileNameWithoutExtension(item);
                        string value = ocr(item, name);
                        this.Invoke((EventHandler)delegate
                        {
                            richTextBox_text.Text += value + Environment.NewLine;
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
                return res;
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--ocr");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                return "";
            }
        }


        /// <summary>
        /// 预览pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdfNumInfo_Page_ClickEvent(object sender, EventArgs e)
        {
            if (file_Address != null && File.Exists(file_Address))
            {
                System.Diagnostics.Process.Start(file_Address);
            }
        }

        private void metroTile_OutData_Click(object sender, EventArgs e)
        {
            try
            {
                string content = richTextBox_text.Text.Trim();
                if (string.IsNullOrEmpty(content))
                {
                    return;
                }

                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.Description = "请选择识别后文件的位置";

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowser.SelectedPath;
                    string name = path + "\\识别PDF文本" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
                    File.WriteAllText(name, content);
                    MessageBox.Show("导出成功！");
                }
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_OutData_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
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
                log4netHelper.Error("---报错方法--metroTile_OutData_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }
    }
}
