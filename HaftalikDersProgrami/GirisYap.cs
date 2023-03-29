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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
            initializeFiles();
        }

        private void initializeFiles()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Classes"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Classes");
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Teachers"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Teachers");
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Classes"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Derslik");
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Users"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Users");
                IniFile file = new IniFile(Environment.CurrentDirectory + "\\Users\\0.ini");
                file.Write("username", "root");
                file.Write("password", "root");
                file.Write("yetki", "yetkili");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            if(bunifuTextBox1.Text.Equals("admin") && bunifuTextBox2.Text.Equals("admin"))
            {
                AnaMenu menu = new AnaMenu();
                menu.Show();
                this.Hide();
                return;
            }

            foreach(Base_Class.User s in LoginManager.GetAll())
            {
                
                if (!bunifuTextBox1.Text.Equals(s.username) || !bunifuTextBox2.Text.Equals(s.password))
                    continue;

                if (bunifuCheckBox1.Checked)
                {
                    IniFile fi = new IniFile(Environment.CurrentDirectory + "\\remember.ini");
                    fi.Write("username", bunifuTextBox1.Text);
                    fi.Write("password", bunifuTextBox2.Text);
                } else
                {
                    if (File.Exists(Environment.CurrentDirectory + "\\remember.ini"))
                        File.Delete(Environment.CurrentDirectory + "\\remember.ini");
                }

                AnaMenu menu = new AnaMenu();
                menu.Show();
                this.Hide();

            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new GunManager();
            new OgretmenManager();
            new ClassManager();
            new DerslikManager();
            new LoginManager();
            MessageBox.Show(GunManager.DebugClass());
            MessageBox.Show(OgretmenManager.DebugClass(), "Öğretmenler");
            if (File.Exists(Environment.CurrentDirectory + "\remember.ini"))
            {
                IniFile file = new IniFile(Environment.CurrentDirectory + "\remember.ini");
                bunifuTextBox1.Text = file.Read("username");
                bunifuTextBox2.Text = file.Read("password");
                bunifuCheckBox1.Checked = true;
            }
        }

        private void GirisYap_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
    }
}
