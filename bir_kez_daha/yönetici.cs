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
    public partial class yönetici : Form
    {
        public yönetici()
        {
            
            InitializeComponent();
        }
        void ChilForm(Form chilform)
        {
            bool durum = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Text== chilform.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if(durum==false)
            {
                chilform.MdiParent = this;
                chilform.Show();
            }
        }
        
        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new ekle());



          
        }

        private void ürünGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new güncelle_sil());
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new musteri_listele());
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new siparis_listele());
        }
    }
}
