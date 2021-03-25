using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrj
{
    public partial class MsgForm : Form
    {
        public MsgForm()
        {
            InitializeComponent();
        }







        public void WriteMsg(string msg)
        {
            msg += "\r\n";
            txt_Msg.AppendText(msg);
        }
    }
}
