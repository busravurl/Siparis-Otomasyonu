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
    public partial class musteri_listele : Form
    {
        public musteri_listele()
        {
            InitializeComponent();
        }

        private void musteri_listele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sipariş_otomasyonDataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.sipariş_otomasyonDataSet2.Customers);

        }
    }
}
