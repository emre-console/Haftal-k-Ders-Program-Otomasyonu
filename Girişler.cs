using HaftalikDersProgrami.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaftalikDersProgrami
{
    public partial class Girişler : Form
    {
        public Girişler()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (duzenle)
            {
                duzenle = false;
                LoginManager.SetUser(dId, new Base_Class.User(dId, bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text));
                listele();
            }
            else
            {
                addListe(bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text);
                LoginManager.AddUser(new Base_Class.User(
                    int.Parse
                        (bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value.ToString()),
                    bunifuTextBox2.Text,
                    bunifuTextBox3.Text,
                    bunifuTextBox4.Text));
            }
                bunifuTextBox2.Text = String.Empty;
            bunifuTextBox3.Text = String.Empty;
            bunifuTextBox4.Text = String.Empty;

        }

        void addListe(string username, string password, string yetki)
        {
            bunifuDataGridView1.Rows.Add();
            try
            {
                bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value = int.Parse(bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
            }
            catch (Exception)
            {
                bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[0].Value = 0;
            }
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[1].Value = username;
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[2].Value = password;
            bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Cells[3].Value = yetki;
        }

        void listele()
        {
            bunifuDataGridView1.Rows.Clear();
            foreach(Base_Class.User s in LoginManager.GetAll())
            {
                addListe(s.username, s.password, s.yetki);
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            

        }


        private void Girişler_Load(object sender, EventArgs e)
        {
            listele();   
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.CurrentDirectory + "\\Users\\" + bunifuDataGridView1.SelectedRows[0].Cells[0].Value + ".ini");
            listele();
        }

        private void Girişler_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AnaMenu().Show();
            LoginManager.Save();
        }

        int dId;
        bool duzenle;

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dId = int.Parse(bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            duzenle = true;
            bunifuTextBox2.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            bunifuTextBox3.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            bunifuTextBox4.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (LoginManager.RemoveUser(id))
                listele();

        }
    }
}
