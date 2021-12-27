namespace Drf_OCR_Manager_UI.SysControls
{
    partial class ImageOCR
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
            this.waiting_Info = new Drf_OCR_Manager_UI.SysControls.Waiting();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.metroTile_cut = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel_Line = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel_Main.Controls.Add(this.pictureBox1);
            this.panel_Main.Controls.Add(this.waiting_Info);
            this.panel_Main.Controls.Add(this.metroTile3);
            this.panel_Main.Controls.Add(this.panel_Info);
            this.panel_Main.Controls.Add(this.metroTile_cut);
            this.panel_Main.Controls.Add(this.metroTile1);
            this.panel_Main.Controls.Add(this.panel_Line);
            this.panel_Main.Controls.Add(this.label1);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(730, 495);
            this.panel_Main.TabIndex = 0;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drf_OCR_Manager_UI.Resource.jpg_1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // waiting_Info
            // 
            this.waiting_Info.Location = new System.Drawing.Point(343, 66);
            this.waiting_Info.Margin = new System.Windows.Forms.Padding(2);
            this.waiting_Info.Name = "waiting_Info";
            this.waiting_Info.Size = new System.Drawing.Size(275, 34);
            this.waiting_Info.TabIndex = 7;
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(234, 60);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(90, 40);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 6;
            this.metroTile3.Text = "导出数据";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
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
            this.panel_Info.Size = new System.Drawing.Size(690, 364);
            this.panel_Info.TabIndex = 6;
            this.panel_Info.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Info_Paint);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_text);
            this.splitContainer1.Size = new System.Drawing.Size(688, 362);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pic_Image
            // 
            this.pic_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Image.Location = new System.Drawing.Point(0, 0);
            this.pic_Image.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(335, 360);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 3;
            this.pic_Image.TabStop = false;
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_text.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_text.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(346, 360);
            this.richTextBox_text.TabIndex = 5;
            this.richTextBox_text.Text = "";
            // 
            // metroTile_cut
            // 
            this.metroTile_cut.Location = new System.Drawing.Point(118, 60);
            this.metroTile_cut.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_cut.Name = "metroTile_cut";
            this.metroTile_cut.Size = new System.Drawing.Size(110, 40);
            this.metroTile_cut.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_cut.TabIndex = 5;
            this.metroTile_cut.Text = "截图识别(F4)";
            this.metroTile_cut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_cut.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_cut.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(22, 60);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(90, 40);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "上传图片";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // panel_Line
            // 
            this.panel_Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Line.BackColor = System.Drawing.Color.Silver;
            this.panel_Line.Location = new System.Drawing.Point(2, 46);
            this.panel_Line.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Line.Name = "panel_Line";
            this.panel_Line.Size = new System.Drawing.Size(750, 1);
            this.panel_Line.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "OCR识别图片";
            // 
            // ImageOCR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImageOCR";
            this.Size = new System.Drawing.Size(730, 495);
            this.Load += new System.EventHandler(this.ImageOCR_Load);
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
        private System.Windows.Forms.Panel panel_Line;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile_cut;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.RichTextBox richTextBox_text;
        private MetroFramework.Controls.MetroTile metroTile3;
        private Waiting waiting_Info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
