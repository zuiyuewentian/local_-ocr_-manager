namespace Drf_OCR_Manager_UI.SysControls
{
    partial class PDFOCR
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile_Start = new MetroFramework.Controls.MetroTile();
            this.waiting_Info = new Drf_OCR_Manager_UI.SysControls.Waiting();
            this.metroTile_OutData = new MetroFramework.Controls.MetroTile();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.pdfNumInfo_Page = new Drf_OCR_Manager_UI.SysControls.PdfNumInfo();
            this.numInfo_ocr = new Drf_OCR_Manager_UI.SysControls.NumInfo();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.metroTile_Select = new MetroFramework.Controls.MetroTile();
            this.panel_Line = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTile_out = new MetroFramework.Controls.MetroTile();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Controls.Add(this.metroTile_out);
            this.panel_Main.Controls.Add(this.pictureBox1);
            this.panel_Main.Controls.Add(this.metroTile_Start);
            this.panel_Main.Controls.Add(this.waiting_Info);
            this.panel_Main.Controls.Add(this.metroTile_OutData);
            this.panel_Main.Controls.Add(this.panel_Info);
            this.panel_Main.Controls.Add(this.metroTile_Select);
            this.panel_Main.Controls.Add(this.panel_Line);
            this.panel_Main.Controls.Add(this.label1);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(814, 465);
            this.panel_Main.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drf_OCR_Manager_UI.Resource.文件类型_Pdf;
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile_Start
            // 
            this.metroTile_Start.Location = new System.Drawing.Point(120, 60);
            this.metroTile_Start.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_Start.Name = "metroTile_Start";
            this.metroTile_Start.Size = new System.Drawing.Size(90, 40);
            this.metroTile_Start.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Start.TabIndex = 10;
            this.metroTile_Start.Text = "开始执行";
            this.metroTile_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Start.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_Start.Click += new System.EventHandler(this.metroTile_Start_Click);
            // 
            // waiting_Info
            // 
            this.waiting_Info.Location = new System.Drawing.Point(452, 66);
            this.waiting_Info.Margin = new System.Windows.Forms.Padding(2);
            this.waiting_Info.Name = "waiting_Info";
            this.waiting_Info.Size = new System.Drawing.Size(306, 34);
            this.waiting_Info.TabIndex = 7;
            // 
            // metroTile_OutData
            // 
            this.metroTile_OutData.Location = new System.Drawing.Point(218, 60);
            this.metroTile_OutData.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_OutData.Name = "metroTile_OutData";
            this.metroTile_OutData.Size = new System.Drawing.Size(90, 40);
            this.metroTile_OutData.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_OutData.TabIndex = 6;
            this.metroTile_OutData.Text = "导出数据";
            this.metroTile_OutData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_OutData.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_OutData.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_OutData.Click += new System.EventHandler(this.metroTile_OutData_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Info.Controls.Add(this.splitContainer1);
            this.panel_Info.Location = new System.Drawing.Point(22, 118);
            this.panel_Info.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(774, 334);
            this.panel_Info.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pic_Image);
            this.splitContainer1.Panel1.Controls.Add(this.pdfNumInfo_Page);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.numInfo_ocr);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_text);
            this.splitContainer1.Size = new System.Drawing.Size(772, 332);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // pic_Image
            // 
            this.pic_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Image.Location = new System.Drawing.Point(4, 43);
            this.pic_Image.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(370, 280);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 4;
            this.pic_Image.TabStop = false;
            // 
            // pdfNumInfo_Page
            // 
            this.pdfNumInfo_Page.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfNumInfo_Page.Location = new System.Drawing.Point(4, 4);
            this.pdfNumInfo_Page.Name = "pdfNumInfo_Page";
            this.pdfNumInfo_Page.Size = new System.Drawing.Size(368, 34);
            this.pdfNumInfo_Page.TabIndex = 0;
            this.pdfNumInfo_Page.TypeName = "共有";
            this.pdfNumInfo_Page.ClickEvent += new Drf_OCR_Manager_UI.SysControls.PdfNumInfo.MyDelegate(this.pdfNumInfo_Page_ClickEvent);
            // 
            // numInfo_ocr
            // 
            this.numInfo_ocr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numInfo_ocr.LastName = "页";
            this.numInfo_ocr.Location = new System.Drawing.Point(2, 4);
            this.numInfo_ocr.Margin = new System.Windows.Forms.Padding(2);
            this.numInfo_ocr.Name = "numInfo_ocr";
            this.numInfo_ocr.Size = new System.Drawing.Size(386, 34);
            this.numInfo_ocr.TabIndex = 6;
            this.numInfo_ocr.TypeName = "已识别";
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_text.Location = new System.Drawing.Point(0, 43);
            this.richTextBox_text.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(391, 287);
            this.richTextBox_text.TabIndex = 5;
            this.richTextBox_text.Text = "";
            // 
            // metroTile_Select
            // 
            this.metroTile_Select.Location = new System.Drawing.Point(22, 60);
            this.metroTile_Select.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_Select.Name = "metroTile_Select";
            this.metroTile_Select.Size = new System.Drawing.Size(90, 40);
            this.metroTile_Select.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Select.TabIndex = 4;
            this.metroTile_Select.Text = "上传PDF";
            this.metroTile_Select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Select.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Select.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_Select.Click += new System.EventHandler(this.metroTile_Select_Click);
            // 
            // panel_Line
            // 
            this.panel_Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Line.BackColor = System.Drawing.Color.Silver;
            this.panel_Line.Location = new System.Drawing.Point(2, 46);
            this.panel_Line.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Line.Name = "panel_Line";
            this.panel_Line.Size = new System.Drawing.Size(834, 1);
            this.panel_Line.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "OCR识别PDF";
            // 
            // metroTile_out
            // 
            this.metroTile_out.Location = new System.Drawing.Point(316, 60);
            this.metroTile_out.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_out.Name = "metroTile_out";
            this.metroTile_out.Size = new System.Drawing.Size(107, 40);
            this.metroTile_out.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_out.TabIndex = 12;
            this.metroTile_out.Text = "输出文件夹";
            this.metroTile_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_out.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_out.Click += new System.EventHandler(this.metroTile_out_Click);
            // 
            // PDFOCR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Main);
            this.Name = "PDFOCR";
            this.Size = new System.Drawing.Size(814, 465);
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private Waiting waiting_Info;
        private MetroFramework.Controls.MetroTile metroTile_OutData;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox_text;
        private MetroFramework.Controls.MetroTile metroTile_Select;
        private System.Windows.Forms.Panel panel_Line;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile metroTile_Start;
        private PdfNumInfo pdfNumInfo_Page;
        private System.Windows.Forms.PictureBox pic_Image;
        private NumInfo numInfo_ocr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile_out;
    }
}
