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
    public partial class NumInfo : UserControl
    {
        public string _type_Name = "共有";

        public string TypeName
        {
            get { return _type_Name; }
            set
            {
                _type_Name = value;
                label2.Text = _type_Name;
                label2.Refresh();
                label_Num.Left = label2.Left + label2.Width + 5;
                label_last.Left = label_Num.Left + label_Num.Width + 5;
            }
        }

        public string _last_Name = "项";

        public string LastName
        {
            get { return _last_Name; }
            set
            {
                _last_Name = value;
                label_last.Text = _last_Name;
                label_last.Refresh();
            }
        }

        public NumInfo()
        {
            InitializeComponent();

            label_Num.Left = label2.Left + label2.Width + 5;
            label_last.Left = label_Num.Left + label_Num.Width + 5;
        }

        public void setValue(int number)
        {
            this.Invoke((EventHandler)delegate
            {
                label_Num.Text = number.ToString();
                label_last.Left = label_Num.Left + label_Num.Width + 5;
            });

        }
    }
}
