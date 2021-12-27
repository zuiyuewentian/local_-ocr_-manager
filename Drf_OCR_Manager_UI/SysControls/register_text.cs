using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drf_OCR_Manager_UI.SysControls
{
    public partial class register_text : UserControl
    {
        public bool _is_select = false;

        public bool Is_Select
        {
            get { return _is_select; }
            set
            {
                _is_select = value;
                richTextBox1.ReadOnly = _is_select;
                richTextBox1.Refresh();
            }
        }

        public string _info_text = "";

        public string Info_text
        {
            get { return _info_text; }
            set
            {
                _info_text = value;
                richTextBox1.Text = _info_text;
                richTextBox1.Refresh();
            }
        }

        public register_text()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
            Color.FromArgb(19, 194, 194), 1, ButtonBorderStyle.Solid, //左边
            Color.FromArgb(19, 194, 194), 1, ButtonBorderStyle.Solid, //上边
            Color.FromArgb(19, 194, 194), 1, ButtonBorderStyle.Solid, //右边
            Color.FromArgb(19, 194, 194), 1, ButtonBorderStyle.Solid);//底边
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            _info_text = richTextBox1.Text;
        }
    }
}
