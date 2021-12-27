using Emgu.CV;
using Emgu.CV.CvEnum;
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
using System.IO;
using MetroFramework.Forms;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class ImageOCR : UserControl
    {
        ConfigModel configModel = new ConfigModel();
        private OcrLite ocrEngin;
        private MainForm T_MainForm;

        /// <summary>
        /// 截图缓存
        /// </summary>
        private string save_Image = Environment.CurrentDirectory + "\\temp.png";

        public ImageOCR(ConfigModel config, MainForm form)
        {
            InitializeComponent();

            configModel = config;
            T_MainForm = form;
            waiting_Info.Visible = false;
        }

        /// <summary>
        /// 执行等待操作
        /// </summary>
        /// <param name="wait"></param>
        private void IsWait(bool wait)
        {
            waiting_Info.Visible = wait;
            metroTile1.Enabled = !wait;
            metroTile_cut.Enabled = !wait;
            metroTile3.Enabled = !wait;
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
                log4netHelper.Error("---报错方法--metroTile_BatchImage_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                MessageBox.Show("初始化异常");
            }
        }

        private void ImageOCR_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainForm.IsResiger)
                    return;

                if (FormIsActive()) return;

                IsWait(true);
                T_MainForm.WindowState = FormWindowState.Minimized;
                Image img = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
                Graphics g = Graphics.FromImage(img);
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size);
                ScreenBody body = new ScreenBody();
                body.BackgroundImage = img;
                body.ShowDialog();

                Image mimg = ScreenBody.myImage;
                mimg.Save(save_Image);
                pic_Image.Image = mimg;
                T_MainForm.WindowState = FormWindowState.Maximized;

                Ocr_Start(save_Image);

            }
            catch (Exception ex)
            {
            }
        }

        private void Ocr_Start(string url)
        {
            try
            {
                Task task = new Task(() =>
                {
                    string res = Ocr_Image(url);
                    this.Invoke((EventHandler)delegate
                    {
                        richTextBox_text.Text = res;
                        IsWait(false);
                    });
                });
                task.Start();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--Ocr_Start");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }

        }

        private string Ocr_Image(string m_save_Image)
        {
            try
            {
                OcrResult ocrResult = ocrEngin.Detect(m_save_Image,
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
                log4netHelper.Error("---报错方法--Ocr_Image");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                return "";
            }

        }

        /// <summary>
        /// 判断截图窗体是否已经打开
        /// </summary>
        /// <returns></returns>
        private bool FormIsActive()
        {
            try
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is ScreenBody)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainForm.IsResiger)
                    return;

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Title = "请选择图片";
                // fileDialog.Filter = "所有文件(*pdf*)|*.jpg*"; //设置要选择的文件的类型
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    IsWait(true);
                    string file = fileDialog.FileName;//返回文件的完整路径     

                    pic_Image.Image = Image.FromFile(file);
                    Ocr_Start(file);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请选择正确的图片");
            }
        }

        public void CutPicture()
        {
            try
            {
                if (FormIsActive()) return;

                IsWait(true);
                T_MainForm.WindowState = FormWindowState.Minimized;
                Image img = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
                Graphics g = Graphics.FromImage(img);
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size);
                ScreenBody body = new ScreenBody();
                body.BackgroundImage = img;
                body.ShowDialog();

                Image mimg = ScreenBody.myImage;
                mimg.Save(save_Image);
                pic_Image.Image = mimg;

                T_MainForm.WindowState = FormWindowState.Maximized;
                Ocr_Start(save_Image);

            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--CutPicture");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
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
                    string name = path + "\\识别文本" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
                    File.WriteAllText(name, content);
                    MessageBox.Show("导出成功！");
                }
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile3_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
          
        }
    }
}
