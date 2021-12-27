namespace Drf_OCR_Manager_UI
{
    partial class CheckSysForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_outloc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_copyuuid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_UUID = new System.Windows.Forms.Label();
            this.metroTile_Start = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroTile_Start);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.tb_outloc);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.groupBox1.Location = new System.Drawing.Point(23, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 214);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入校验码";
            // 
            // tb_outloc
            // 
            this.tb_outloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_outloc.BackColor = System.Drawing.Color.White;
            this.tb_outloc.Location = new System.Drawing.Point(83, 89);
            this.tb_outloc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_outloc.Name = "tb_outloc";
            this.tb_outloc.PasswordChar = '#';
            this.tb_outloc.Size = new System.Drawing.Size(593, 27);
            this.tb_outloc.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(10, 92);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 56;
            this.label15.Text = "校验码：";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.label_copyuuid);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label_UUID);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(14, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 39);
            this.panel2.TabIndex = 59;
            // 
            // label_copyuuid
            // 
            this.label_copyuuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_copyuuid.AutoSize = true;
            this.label_copyuuid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label_copyuuid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_copyuuid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_copyuuid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_copyuuid.Location = new System.Drawing.Point(611, 9);
            this.label_copyuuid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_copyuuid.Name = "label_copyuuid";
            this.label_copyuuid.Size = new System.Drawing.Size(46, 24);
            this.label_copyuuid.TabIndex = 59;
            this.label_copyuuid.Text = "复制";
            this.label_copyuuid.Click += new System.EventHandler(this.label_copyuuid_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 58;
            this.label7.Text = "系统唯一标识UUID";
            // 
            // label_UUID
            // 
            this.label_UUID.AutoSize = true;
            this.label_UUID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.label_UUID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label_UUID.Location = new System.Drawing.Point(235, 11);
            this.label_UUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UUID.Name = "label_UUID";
            this.label_UUID.Size = new System.Drawing.Size(175, 20);
            this.label_UUID.TabIndex = 56;
            this.label_UUID.Text = "GUFD-IUY9-OLKF-097Y";
            // 
            // metroTile_Start
            // 
            this.metroTile_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile_Start.Location = new System.Drawing.Point(581, 140);
            this.metroTile_Start.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile_Start.Name = "metroTile_Start";
            this.metroTile_Start.Size = new System.Drawing.Size(90, 40);
            this.metroTile_Start.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Start.TabIndex = 60;
            this.metroTile_Start.Text = "开始校验";
            this.metroTile_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Start.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_Start.Click += new System.EventHandler(this.metroTile_Start_Click);
            // 
            // CheckSysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CheckSysForm";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "校验系统";
            this.Load += new System.EventHandler(this.CheckSysForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_outloc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_copyuuid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_UUID;
        private MetroFramework.Controls.MetroTile metroTile_Start;
    }
}