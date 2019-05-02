using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Desktop.LoginServiceReference;


namespace Desktop
{
    public partial class LoginEkran : MetroFramework.Forms.MetroForm
    {
        public LoginEkran()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginServiceSoapClient proxy = new LoginServiceSoapClient();
            string kullanici = txtKullanici.Text;
            string sifre = txtSifre.Text;

            bool secenek = proxy.Login(kullanici,sifre);

            if (secenek)
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }

        }

        private void btnDbGuncelle_Click(object sender, EventArgs e)
        {
            IFillDatabaseService service = Business.IOCUtil.Resolve<IFillDatabaseService>();
            service.Fill();
        }
    }
}
