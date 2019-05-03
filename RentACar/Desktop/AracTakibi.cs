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
    public partial class AracTakibi : MetroFramework.Forms.MetroForm
    {
        public AracTakibi()
        {
            InitializeComponent();

            VehicleServiceServiceSoapClient vehicle = new VehicleServiceServiceSoapClient();
           dataGridAracTakip.DataSource = (object)vehicle.GetAll();

        }
    }
}
