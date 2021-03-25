using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrj.FormArea.IndexDataSet
{
    public partial class IndexDataForm : Form
    {
        public IndexDataForm()
        {
            InitializeComponent();
        }

        public event Action<string> WriteMsg;

        private void BtnCheckData_Click(object sender, EventArgs e)
        {
            WriteMsg?.Invoke("开始检验");
        }
    }
}
