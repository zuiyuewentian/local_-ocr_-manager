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
    public partial class Waiting : UserControl
    {
        public Waiting()
        {
            InitializeComponent();
        }

        public void SetShowValue(string value)
        {
            this.Invoke((EventHandler)delegate
            {
                label2.Text = value;
            });
        }
    }
}
