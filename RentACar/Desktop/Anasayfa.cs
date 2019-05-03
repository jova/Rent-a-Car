using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Anasayfa : MetroFramework.Forms.MetroForm
    {
        public Anasayfa()
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

        


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MusteriIstekleri_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new MusteriIstekleri()));
        }

        

        private void AracListeleme_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new SirketAracDurumListeleme()));
        }

        private void araçTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new AracTakibi()));
        }
    }
}
