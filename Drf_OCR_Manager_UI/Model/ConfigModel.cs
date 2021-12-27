using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drf_OCR_Manager_UI.Model
{
    public class ConfigModel
    {
        /// <summary>
        /// 模型所在文件夹路径，可以相对路径也可以绝对路径。
        /// </summary>
        public string modelsDir { get; set; }

        /// <summary>
        /// dbNet模型文件名(含扩展名)
        /// </summary>
        public string detPath { get; set; }

        /// <summary>
        /// angleNet模型文件名(含扩展名)
        /// </summary>
        public string clsPath { get; set; }

        /// <summary>
        /// crnnNet模型文件名(含扩展名)
        /// </summary>
        public string recPath { get; set; }

        /// <summary>
        ///  keys.txt文件名(含扩展名)
        /// </summary>
        public string keysPath { get; set; }

        /// <summary>
        /// 线程数量
        /// </summary>
        public int numThreadNumeric { get; set; }

        /// <summary>
        /// 图像预处理，在图片外周添加白边，用于提升识别率，文字框没有正确框住所有文字时，增加此值。
        /// </summary>
        public int padding { get; set; }

        /// <summary>
        /// 按图片最长边的长度，此值为0代表不缩放，例：1024，如果图片长边大于1024则把图像整体缩小到1024再进行图像分割计算，如果图片长边小于1024则不缩放，如果图片长边小于32，则缩放到32。
        /// </summary>
        public int imgResize { get; set; }

        /// <summary>
        /// 文字框置信度门限，文字框没有正确框住所有文字时，减小此值。
        /// </summary>
        public float boxScoreThresh { get; set; }

        /// <summary>
        /// boxThresh
        /// </summary>
        public float boxThresh { get; set; }

        /// <summary>
        /// 单个文字框大小倍率，越大时单个文字框越大。此项与图片的大小相关，越大的图片此值应该越大。
        /// </summary>
        public float unClipRatio { get; set; }

        /// <summary>
        /// 启用(1)/禁用(0) 文字方向检测，只有图片倒置的情况下(旋转90~270度的图片)，才需要启用文字方向检测。
        /// </summary>
        public bool doAngle { get; set; }

        /// <summary>
        /// 启用(1)/禁用(0) 角度投票(整张图片以最大可能文字方向来识别)，当禁用文字方向检测时，此项也不起作用。
        /// </summary>
        public bool mostAngle { get; set; }

        /// <summary>
        /// 是否启用网络OCR
        /// </summary>
        public bool IsNetOCR { get; set; }

        /// <summary>
        /// 输出文件夹地址
        /// </summary>
        public string Out_Location { get; set; }
    }
}
