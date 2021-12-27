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
    public partial class version_select : UserControl
    {
        public bool _is_select = true;

        public bool Is_Select
        {
            get { return _is_select; }
            set
            {
                _is_select = value;
                pic_select.Visible = _is_select;
                pic_select.Refresh();
            }
        }

        public string _info_text = "个人离线版";

        public string Info_text
        {
            get { return _info_text; }
            set
            {
                _info_text = value;
                label2.Text = _info_text;
                label2.Refresh();
                pic_select.Left = label2.Left + label2.Width + 2;
            }
        }

        public version_select()
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
    }
}
