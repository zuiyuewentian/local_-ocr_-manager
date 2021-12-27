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
    public partial class PdfNumInfo : UserControl
    {
        public string _type_Name = "共有";

        public delegate void MyDelegate(object sender, EventArgs e);

        public event MyDelegate ClickEvent;

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

        public PdfNumInfo()
        {
            InitializeComponent();

            label_Num.Left = label2.Left + label2.Width + 5;
            label_last.Left = label_Num.Left + label_Num.Width + 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
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
