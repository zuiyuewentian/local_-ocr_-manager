namespace Drf_OCR_Manager_UI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.lab_register = new System.Windows.Forms.Label();
            this.metroTile_about = new MetroFramework.Controls.MetroTile();
            this.metroTile_Config = new MetroFramework.Controls.MetroTile();
            this.metroTile_batchOcr = new MetroFramework.Controls.MetroTile();
            this.metroTile_BatchImage = new MetroFramework.Controls.MetroTile();
            this.metroTile_PDF = new MetroFramework.Controls.MetroTile();
            this.metroTile_ocr = new MetroFramework.Controls.MetroTile();
            this.metroTile5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Location = new System.Drawing.Point(359, 98);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(690, 633);
            this.panel_Main.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 765);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copyright@2021 南京动如风科技有限公司";
            // 
            // metroTile5
            // 
            this.metroTile5.Controls.Add(this.lab_register);
            this.metroTile5.Location = new System.Drawing.Point(39, 352);
            this.metroTile5.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(289, 120);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile5.TabIndex = 6;
            this.metroTile5.Text = "已经注册正版";
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // lab_register
            // 
            this.lab_register.BackColor = System.Drawing.Color.Transparent;
            this.lab_register.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_register.ForeColor = System.Drawing.Color.White;
            this.lab_register.Location = new System.Drawing.Point(50, 49);
            this.lab_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_register.Name = "lab_register";
            this.lab_register.Size = new System.Drawing.Size(172, 27);
            this.lab_register.TabIndex = 0;
            this.lab_register.Text = "个人离线版V1.0.0";
            this.lab_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_register.Click += new System.EventHandler(this.lab_register_Click);
            // 
            // metroTile_about
            // 
            this.metroTile_about.Location = new System.Drawing.Point(186, 481);
            this.metroTile_about.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_about.Name = "metroTile_about";
            this.metroTile_about.Size = new System.Drawing.Size(140, 120);
            this.metroTile_about.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_about.TabIndex = 8;
            this.metroTile_about.Text = "关于";
            this.metroTile_about.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_about.TileImage = global::Drf_OCR_Manager_UI.Resource.文件类型_链接;
            this.metroTile_about.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_about.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_about.UseTileImage = true;
            this.metroTile_about.Click += new System.EventHandler(this.metroTile_about_Click);
            // 
            // metroTile_Config
            // 
            this.metroTile_Config.Location = new System.Drawing.Point(39, 481);
            this.metroTile_Config.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_Config.Name = "metroTile_Config";
            this.metroTile_Config.Size = new System.Drawing.Size(140, 120);
            this.metroTile_Config.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_Config.TabIndex = 7;
            this.metroTile_Config.Text = "系统配置";
            this.metroTile_Config.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Config.TileImage = global::Drf_OCR_Manager_UI.Resource.文件类型_配置文件;
            this.metroTile_Config.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Config.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_Config.UseTileImage = true;
            this.metroTile_Config.Click += new System.EventHandler(this.metroTile_Config_Click);
            // 
            // metroTile_batchOcr
            // 
            this.metroTile_batchOcr.Location = new System.Drawing.Point(186, 225);
            this.metroTile_batchOcr.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_batchOcr.Name = "metroTile_batchOcr";
            this.metroTile_batchOcr.Size = new System.Drawing.Size(140, 120);
            this.metroTile_batchOcr.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_batchOcr.TabIndex = 3;
            this.metroTile_batchOcr.Text = "批量识别PDF";
            this.metroTile_batchOcr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_batchOcr.TileImage = global::Drf_OCR_Manager_UI.Resource.文件类型_数据库2;
            this.metroTile_batchOcr.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_batchOcr.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_batchOcr.UseTileImage = true;
            this.metroTile_batchOcr.Click += new System.EventHandler(this.metroTile_batchOcr_Click);
            // 
            // metroTile_BatchImage
            // 
            this.metroTile_BatchImage.Location = new System.Drawing.Point(39, 225);
            this.metroTile_BatchImage.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_BatchImage.Name = "metroTile_BatchImage";
            this.metroTile_BatchImage.Size = new System.Drawing.Size(140, 120);
            this.metroTile_BatchImage.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_BatchImage.TabIndex = 2;
            this.metroTile_BatchImage.Text = "批量识别图片";
            this.metroTile_BatchImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_BatchImage.TileImage = global::Drf_OCR_Manager_UI.Resource.图片JPG;
            this.metroTile_BatchImage.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_BatchImage.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_BatchImage.UseTileImage = true;
            this.metroTile_BatchImage.Click += new System.EventHandler(this.metroTile_BatchImage_Click);
            // 
            // metroTile_PDF
            // 
            this.metroTile_PDF.Location = new System.Drawing.Point(186, 98);
            this.metroTile_PDF.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_PDF.Name = "metroTile_PDF";
            this.metroTile_PDF.Size = new System.Drawing.Size(140, 120);
            this.metroTile_PDF.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_PDF.TabIndex = 1;
            this.metroTile_PDF.Text = "OCR识别PDF";
            this.metroTile_PDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_PDF.TileImage = global::Drf_OCR_Manager_UI.Resource.PDF__2_;
            this.metroTile_PDF.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_PDF.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_PDF.UseTileImage = true;
            this.metroTile_PDF.Click += new System.EventHandler(this.metroTile_PDF_Click);
            // 
            // metroTile_ocr
            // 
            this.metroTile_ocr.Location = new System.Drawing.Point(39, 98);
            this.metroTile_ocr.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_ocr.Name = "metroTile_ocr";
            this.metroTile_ocr.Size = new System.Drawing.Size(140, 120);
            this.metroTile_ocr.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_ocr.TabIndex = 0;
            this.metroTile_ocr.Text = "OCR识别图片";
            this.metroTile_ocr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_ocr.TileImage = global::Drf_OCR_Manager_UI.Resource.jpg_1;
            this.metroTile_ocr.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_ocr.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_ocr.UseTileImage = true;
            this.metroTile_ocr.Click += new System.EventHandler(this.metroTile_ocr_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1086, 800);
            this.Controls.Add(this.metroTile_about);
            this.Controls.Add(this.metroTile_Config);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.metroTile_batchOcr);
            this.Controls.Add(this.metroTile_BatchImage);
            this.Controls.Add(this.metroTile_PDF);
            this.Controls.Add(this.metroTile_ocr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(19, 75, 19, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "超影-智能办公-测试版本请勿商用";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTile5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile_ocr;
        private MetroFramework.Controls.MetroTile metroTile_PDF;
        private MetroFramework.Controls.MetroTile metroTile_BatchImage;
        private MetroFramework.Controls.MetroTile metroTile_batchOcr;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile_Config;
        private MetroFramework.Controls.MetroTile metroTile_about;
        private System.Windows.Forms.Label lab_register;
    }
}

