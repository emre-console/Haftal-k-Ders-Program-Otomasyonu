using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaftalikDersProgrami
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void Btnogretmenler_Click(object sender, EventArgs e)
        {
            new Ogretmenler().Show();
            this.Dispose();
        }

        private void btnGirisler_Click(object sender, EventArgs e)
        {
            new Girişler().Show();
            this.Dispose();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
            
        }

        private void Btndersler_Click(object sender, EventArgs e)
        {
            new Dersler().Show();
            this.Dispose();
        }

        private void Btnderslikler_Click(object sender, EventArgs e)
        {
            new Derslikler().Show();
            this.Dispose();
        }

        private void BtnDersProg_Click(object sender, EventArgs e)
        {
            new SubeBilgiler().Show();
            this.Dispose();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
