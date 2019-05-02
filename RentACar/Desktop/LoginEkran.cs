using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.LoginServiceReference;


namespace Desktop
{
    public partial class LoginEkran : MetroFramework.Forms.MetroForm
    {
        public LoginEkran()
        {
            InitializeComponent();
        }

        private void MdiFormsClose()
        {
            //close all child form
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }
        private void MdiFormsShow(Form chForm)
        {
            chForm.Show();
        }

        private Form MdiFormsStyle(Form chForm)
        {
            chForm.MdiParent = this;
            chForm.LayoutMdi(MdiLayout.Cascade);
            chForm.StartPosition = FormStartPosition.Manual;
            chForm.Location = new Point(0, 0); // Always opens the forms at 15,15
            chForm.Dock = DockStyle.Fill;
            return chForm;
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {



            LoginServiceSoapClient proxy = new LoginServiceSoapClient();
            string kullanici = txtKullanici.Text;
            string sifre = txtSifre.Text;

            bool secenek = proxy.Login(kullanici,sifre);


            if (secenek)
            {
                MdiFormsClose();
                MdiFormsShow(MdiFormsStyle(new Anasayfa()));
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }

        }
    }
}
