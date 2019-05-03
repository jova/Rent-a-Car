using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.VehicleServiceReference;

namespace Desktop
{
    public partial class SirketAracDurumListeleme : MetroFramework.Forms.MetroForm
    {
        public SirketAracDurumListeleme()
        {
            InitializeComponent();


         


            VehicleServiceServiceSoapClient Vehicle = new VehicleServiceServiceSoapClient();
            dataGridDurumBilgisi.DataSource = (object)Vehicle.GetAll();

        }

        private void dataGridDurumBilgisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
