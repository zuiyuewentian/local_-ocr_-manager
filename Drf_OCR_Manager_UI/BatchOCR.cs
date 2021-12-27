using OcrLiteLib;
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
    public partial class BatchOCR : Form
    {
        private OcrLite ocrEngin;
        private int numThreadNumeric = 4;//线程数量
        int padding = 10;
        int imgResize = 1024;
        float boxScoreThresh = 0.618f;
        float boxThresh = 0.3f;
        float unClipRatio = 2.0f;
        bool doAngle = true;
        bool mostAngle = true;

        public BatchOCR()
        {
            InitializeComponent();
        }

        private void BatchOCR_Load(object sender, EventArgs e)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string appDir = Directory.GetParent(appPath).FullName;
            string modelsDir = appPath + "models";

            string detPath = modelsDir + "\\dbnet.onnx";
            string clsPath = modelsDir + "\\angle_net.onnx";
            string recPath = modelsDir + "\\crnn_lite_lstm.onnx";
            string keysPath = modelsDir + "\\keys.txt";
            bool isDetExists = File.Exists(detPath);
            if (!isDetExists)
            {
                MessageBox.Show("模型文件不存在:" + detPath);
            }
            bool isClsExists = File.Exists(clsPath);
            if (!isClsExists)
            {
                MessageBox.Show("模型文件不存在:" + clsPath);
            }
            bool isRecExists = File.Exists(recPath);
            if (!isRecExists)
            {
                MessageBox.Show("模型文件不存在:" + recPath);
            }
            bool isKeysExists = File.Exists(keysPath);
            if (!isKeysExists)
            {
                MessageBox.Show("Keys文件不存在:" + keysPath);
            }
            if (isDetExists && isClsExists && isRecExists && isKeysExists)
            {
                ocrEngin = new OcrLite();
                ocrEngin.InitModels(detPath, clsPath, recPath, keysPath, numThreadNumeric);
            }
            else
            {
                MessageBox.Show("初始化失败，请确认模型文件夹和文件后，重新初始化！");
            }
        }

        public List<string> imgList = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择待识别文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string url = dialog.SelectedPath;
                imgList = Directory.GetFiles(url).ToList();
                foreach (var item in imgList)
                {
                    richTextBox1.Text += item + Environment.NewLine;
                }
                //lblSelete.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                Console.WriteLine("使用System.Threading.Tasks.Task执行异步操作.");
                foreach (var item in imgList)
                {
                    string name = Path.GetFileNameWithoutExtension(item);
                    string value = ocr(item, name);
                    this.Invoke((EventHandler)delegate
                    {
                        richTextBox2.Text += value + Environment.NewLine;
                    });
                }
            });
            task.Start();
          
        }

        private string ocr(string url, string name)
        {
            OcrResult ocrResult = ocrEngin.Detect(url, padding, imgResize, boxScoreThresh, boxThresh, unClipRatio, doAngle, mostAngle);
            string res = ocrResult.StrRes;
            File.WriteAllText("text\\" + name + ".txt", res);
            return name + ".txt";
            //ocrResultTextBox.Text = ocrResult.ToString();
            //strRestTextBox.Text = ocrResult.StrRes;
            //pictureBox.Image = ocrResult.BoxImg.ToBitmap();
        }
    }
}
