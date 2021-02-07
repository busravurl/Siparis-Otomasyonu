using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bir_kez_daha
{
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kredikarti kart = new kredikarti();
            kart.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nakit_frm nakit = new nakit_frm();
            nakit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cek_frm cek = new cek_frm();
            cek.Show();
        }
       


    }
}
