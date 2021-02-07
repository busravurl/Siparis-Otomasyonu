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
    public partial class cek_frm : Form
    {
        public cek_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme İşlemi Tamamlandı..");
            this.Close();
            
        }
    }
}
