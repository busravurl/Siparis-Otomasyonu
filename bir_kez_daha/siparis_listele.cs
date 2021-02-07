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
    public partial class siparis_listele : Form
    {
        public siparis_listele()
        {
            InitializeComponent();
        }

        private void siparis_listele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sipariş_otomasyonDataSet6.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.sipariş_otomasyonDataSet6.Orders);
            // TODO: This line of code loads data into the 'sipariş_otomasyonDataSet5.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.sipariş_otomasyonDataSet5.Orders);

        }
    }
}
