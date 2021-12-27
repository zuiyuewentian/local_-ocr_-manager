using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Drf_OCR_Manager_UI.Model;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class Config : UserControl
    {
        private MainForm T_MainForm;

        /// <summary>
        /// 默认输出地址
        /// </summary>
        private string default_outloc = Environment.CurrentDirectory + "\\texts\\";

        public Config(MainForm form)
        {
            InitializeComponent();

            T_MainForm = form;

        }

        private void Config_Load(object sender, EventArgs e)
        {
            InitConfig();
        }

        private void InitConfig()
        {
            try
            {
                string config_path = Environment.CurrentDirectory + "\\Config.json";
                tb_outloc.Text = default_outloc;
                bool isEx = File.Exists(config_path);
                if (isEx)
                {
                    var json = File.ReadAllText(config_path);
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(json);
                    numericUpDown1.Value = data.numThreadNumeric;
                    textBox1.Text = data.padding.ToString();
                    textBox2.Text = data.imgResize.ToString();
                    textBox3.Text = data.boxScoreThresh.ToString();
                    textBox4.Text = data.boxThresh.ToString();
                    textBox5.Text = data.unClipRatio.ToString();
                    checkBox_doAngle.Checked = data.doAngle;
                    checkBox_mostAngle.Checked = data.mostAngle;
                    checkBox_IsNetOCR.Checked = data.IsNetOCR;

                    tb_outloc.Text = Environment.CurrentDirectory + data.Out_Location;
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

        private void metroTile_Save_Click(object sender, EventArgs e)
        {

            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string appDir = Directory.GetParent(appPath).FullName;
            string modelsDir = appPath + "models";

            string detPath = "\\models\\dbnet.onnx";
            string clsPath = "\\models\\angle_net.onnx";
            string recPath = "\\models\\crnn_lite_lstm.onnx";
            string keysPath = "\\models\\keys.txt";

            string baseAddress = Environment.CurrentDirectory;
            bool isDetExists = File.Exists(baseAddress + detPath);
            if (!isDetExists)
            {
                MessageBox.Show("模型文件不存在:" + baseAddress + detPath);
                return;
            }
            bool isClsExists = File.Exists(baseAddress + clsPath);
            if (!isClsExists)
            {
                MessageBox.Show("模型文件不存在:" + baseAddress + clsPath);
                return;
            }
            bool isRecExists = File.Exists(baseAddress + recPath);
            if (!isRecExists)
            {
                MessageBox.Show("模型文件不存在:" + baseAddress + recPath);
                return;
            }
            bool isKeysExists = File.Exists(baseAddress + keysPath);
            if (!isKeysExists)
            {
                MessageBox.Show("Keys文件不存在:" + baseAddress + keysPath);
                return;
            }

            int numThreadNumeric = 4;
            string countThread = numericUpDown1.Value.ToString();
            numThreadNumeric = Int32.Parse(countThread);

            string padding_text = textBox1.Text.Trim();
            int padding;
            if (!Int32.TryParse(padding_text, out padding))
            {
                MessageBox.Show("图像预处理必须是数字");
                return;
            }
            string imgResize_text = textBox2.Text.Trim();
            int imgResize;
            if (!Int32.TryParse(imgResize_text, out imgResize))
            {
                MessageBox.Show("图片最长边必须是数字");
                return;
            }

            string boxScoreThresh_text = textBox3.Text.Trim();
            float boxScoreThresh;
            if (!float.TryParse(boxScoreThresh_text, out boxScoreThresh))
            {
                MessageBox.Show("文字框置信度必须是数字");
                return;
            }

            string boxThresh_text = textBox4.Text.Trim();
            float boxThresh;
            if (!float.TryParse(boxThresh_text, out boxThresh))
            {
                MessageBox.Show("模糊区域得分必须是数字");
                return;
            }

            string unClipRatio_text = textBox5.Text.Trim();
            float unClipRatio;
            if (!float.TryParse(unClipRatio_text, out unClipRatio))
            {
                MessageBox.Show("框大小倍率必须是数字");
                return;
            }

            try
            {
                ConfigModel configModel = new ConfigModel();
                configModel.modelsDir = "\\models\\";
                configModel.detPath = detPath;
                configModel.clsPath = clsPath;
                configModel.recPath = recPath;
                configModel.keysPath = keysPath;
                configModel.numThreadNumeric = numThreadNumeric;
                configModel.padding = padding;
                configModel.imgResize = imgResize;
                configModel.boxScoreThresh = boxScoreThresh;
                configModel.boxThresh = boxThresh;
                configModel.unClipRatio = unClipRatio;
                configModel.doAngle = checkBox_doAngle.Checked;
                configModel.mostAngle = checkBox_mostAngle.Checked;
                configModel.IsNetOCR = checkBox_IsNetOCR.Checked;

                string address = tb_outloc.Text.Trim();
                if (address == default_outloc)
                {
                    configModel.Out_Location = "\\texts\\";
                }
                else
                {
                    configModel.Out_Location = address;
                }

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(configModel);
                MessageBox.Show("保存成功！");
                T_MainForm.ReInitConfig();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_Save_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
          
        }

        private void metroTile_reset_Click(object sender, EventArgs e)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string appDir = Directory.GetParent(appPath).FullName;
            string modelsDir = appPath + "models";

            string detPath = "\\models\\dbnet.onnx";
            string clsPath = "\\models\\angle_net.onnx";
            string recPath = "\\models\\crnn_lite_lstm.onnx";
            string keysPath = "\\models\\keys.txt";

            string baseAddress = Environment.CurrentDirectory;
            bool isDetExists = File.Exists(baseAddress + detPath);
            if (!isDetExists)
            {
                MessageBox.Show("模型文件不存在:" + baseAddress + detPath);
                return;
            }
            bool isClsExists = File.Exists(baseAddress + clsPath);
            if (!isClsExists)
            {
                MessageBox.Show("模型文件不存在:" + baseAddress + clsPath);
                return;
            }
            bool isRecExists = File.Exists(baseAddress + recPath);
            if (!isRecExists)
            {
                MessageBox.Show("模型文件不存在:" + baseAddress + recPath);
                return;
            }
            bool isKeysExists = File.Exists(baseAddress + keysPath);
            if (!isKeysExists)
            {
                MessageBox.Show("Keys文件不存在:" + baseAddress + keysPath);
                return;
            }

            try
            {
                int numThreadNumeric = 4;
                int padding = 10;
                int imgResize = 1024;
                float boxScoreThresh = 0.618f;
                float boxThresh = 0.3f;
                float unClipRatio = 2.0f;
                bool doAngle = true;
                bool mostAngle = true;

                ConfigModel configModel = new ConfigModel();
                configModel.modelsDir = "\\models\\";
                configModel.detPath = detPath;
                configModel.clsPath = clsPath;
                configModel.recPath = recPath;
                configModel.keysPath = keysPath;
                configModel.numThreadNumeric = numThreadNumeric;
                configModel.padding = padding;
                configModel.imgResize = imgResize;
                configModel.boxScoreThresh = boxScoreThresh;
                configModel.boxThresh = boxThresh;
                configModel.unClipRatio = unClipRatio;
                configModel.doAngle = doAngle;
                configModel.mostAngle = mostAngle;
                configModel.IsNetOCR = !checkBox_IsNetOCR.Checked;

                configModel.Out_Location = "\\texts\\";
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(configModel);
                File.WriteAllText("Config.json", json);
                MessageBox.Show("设置成功！");
                T_MainForm.ReInitConfig();
                InitConfig();
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--metroTile_reset_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
          
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择待识别文件路径";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string url = dialog.SelectedPath + "\\";
                    tb_outloc.Text = url;
                }
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--btn_select_Click");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
            }
          
        }


    }
}
