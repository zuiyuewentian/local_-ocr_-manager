namespace Drf_OCR_Manager_UI.SysControls
{
    partial class BatchPDFOCR
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
            this.metroTile_select = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile_Start = new MetroFramework.Controls.MetroTile();
            this.metroTile_out = new MetroFramework.Controls.MetroTile();
            this.waiting_Info = new Drf_OCR_Manager_UI.SysControls.Waiting();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numInfo_read = new Drf_OCR_Manager_UI.SysControls.NumInfo();
            this.richTextBox_list = new System.Windows.Forms.RichTextBox();
            this.numInfo_ocr = new Drf_OCR_Manager_UI.SysControls.NumInfo();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.panel_Line = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Controls.Add(this.metroTile_select);
            this.panel_Main.Controls.Add(this.pictureBox1);
            this.panel_Main.Controls.Add(this.metroTile_Start);
            this.panel_Main.Controls.Add(this.metroTile_out);
            this.panel_Main.Controls.Add(this.waiting_Info);
            this.panel_Main.Controls.Add(this.panel_Info);
            this.panel_Main.Controls.Add(this.panel_Line);
            this.panel_Main.Controls.Add(this.label1);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(777, 456);
            this.panel_Main.TabIndex = 2;
            // 
            // metroTile_select
            // 
            this.metroTile_select.Location = new System.Drawing.Point(22, 60);
            this.metroTile_select.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_select.Name = "metroTile_select";
            this.metroTile_select.Size = new System.Drawing.Size(130, 40);
            this.metroTile_select.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_select.TabIndex = 4;
            this.metroTile_select.Text = "选中PDF文件夹";
            this.metroTile_select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_select.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_select.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_select.Click += new System.EventHandler(this.metroTile_select_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drf_OCR_Manager_UI.Resource.文件类型_数据库2;
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile_Start
            // 
            this.metroTile_Start.Location = new System.Drawing.Point(161, 60);
            this.metroTile_Start.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_Start.Name = "metroTile_Start";
            this.metroTile_Start.Size = new System.Drawing.Size(90, 40);
            this.metroTile_Start.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Start.TabIndex = 9;
            this.metroTile_Start.Text = "开始执行";
            this.metroTile_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Start.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_Start.Click += new System.EventHandler(this.metroTile_Start_Click);
            // 
            // metroTile_out
            // 
            this.metroTile_out.Location = new System.Drawing.Point(260, 60);
            this.metroTile_out.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_out.Name = "metroTile_out";
            this.metroTile_out.Size = new System.Drawing.Size(107, 40);
            this.metroTile_out.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_out.TabIndex = 8;
            this.metroTile_out.Text = "输出文件夹";
            this.metroTile_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_out.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_out.Click += new System.EventHandler(this.metroTile_out_Click);
            // 
            // waiting_Info
            // 
            this.waiting_Info.Location = new System.Drawing.Point(379, 66);
            this.waiting_Info.Margin = new System.Windows.Forms.Padding(2);
            this.waiting_Info.Name = "waiting_Info";
            this.waiting_Info.Size = new System.Drawing.Size(379, 34);
            this.waiting_Info.TabIndex = 7;
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
            this.panel_Info.Size = new System.Drawing.Size(737, 324);
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
            this.splitContainer1.Panel1.Controls.Add(this.numInfo_read);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox_list);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.numInfo_ocr);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_text);
            this.splitContainer1.Size = new System.Drawing.Size(735, 322);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // numInfo_read
            // 
            this.numInfo_read.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numInfo_read.LastName = "项";
            this.numInfo_read.Location = new System.Drawing.Point(4, 4);
            this.numInfo_read.Margin = new System.Windows.Forms.Padding(2);
            this.numInfo_read.Name = "numInfo_read";
            this.numInfo_read.Size = new System.Drawing.Size(352, 34);
            this.numInfo_read.TabIndex = 7;
            this.numInfo_read.TypeName = "共有";
            // 
            // richTextBox_list
            // 
            this.richTextBox_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_list.BackColor = System.Drawing.Color.White;
            this.richTextBox_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_list.Location = new System.Drawing.Point(6, 46);
            this.richTextBox_list.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_list.Name = "richTextBox_list";
            this.richTextBox_list.ReadOnly = true;
            this.richTextBox_list.Size = new System.Drawing.Size(350, 272);
            this.richTextBox_list.TabIndex = 6;
            this.richTextBox_list.Text = "";
            // 
            // numInfo_ocr
            // 
            this.numInfo_ocr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numInfo_ocr.LastName = "项";
            this.numInfo_ocr.Location = new System.Drawing.Point(6, 4);
            this.numInfo_ocr.Margin = new System.Windows.Forms.Padding(2);
            this.numInfo_ocr.Name = "numInfo_ocr";
            this.numInfo_ocr.Size = new System.Drawing.Size(364, 34);
            this.numInfo_ocr.TabIndex = 6;
            this.numInfo_ocr.TypeName = "已识别";
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_text.BackColor = System.Drawing.Color.White;
            this.richTextBox_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_text.Location = new System.Drawing.Point(0, 46);
            this.richTextBox_text.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.ReadOnly = true;
            this.richTextBox_text.Size = new System.Drawing.Size(370, 275);
            this.richTextBox_text.TabIndex = 5;
            this.richTextBox_text.Text = "";
            // 
            // panel_Line
            // 
            this.panel_Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Line.BackColor = System.Drawing.Color.Silver;
            this.panel_Line.Location = new System.Drawing.Point(2, 46);
            this.panel_Line.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Line.Name = "panel_Line";
            this.panel_Line.Size = new System.Drawing.Size(797, 1);
            this.panel_Line.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "批量识别PDF";
            // 
            // BatchPDFOCR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Main);
            this.Name = "BatchPDFOCR";
            this.Size = new System.Drawing.Size(777, 456);
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private MetroFramework.Controls.MetroTile metroTile_Start;
        private MetroFramework.Controls.MetroTile metroTile_out;
        private Waiting waiting_Info;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private NumInfo numInfo_read;
        private System.Windows.Forms.RichTextBox richTextBox_list;
        private NumInfo numInfo_ocr;
        private System.Windows.Forms.RichTextBox richTextBox_text;
        private MetroFramework.Controls.MetroTile metroTile_select;
        private System.Windows.Forms.Panel panel_Line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
