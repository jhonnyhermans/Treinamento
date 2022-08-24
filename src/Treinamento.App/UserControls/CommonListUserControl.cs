using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento.App.UserControls
{
    public partial class CommonListUserControl : UserControl
    {
        public CommonListUserControl()
        {
            InitializeComponent();
        }

        public bool VisibleEmailButtom { get => btnEmail.Visible; set => btnEmail.Visible = value; }
    }
}
