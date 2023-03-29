using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaftalikDersProgrami.Managers
{
    public class ClassManager
    {

        private static LinkedList<Base_Class.Class> list = new LinkedList<Base_Class.Class>();

        public ClassManager()
        {
            LoadFiles();
        }

        void LoadFiles()
        {
            list.Clear();
            foreach(FileInfo info in new DirectoryInfo(Environment.CurrentDirectory + "\\Classes").GetFiles())
            {
                IniFile file = new IniFile(info.FullName);
                Base_Class.Class c = new Base_Class.Class();
                c.id = int.Parse(info.Name.Substring(0, info.Name.Length - 4));
                c.name = file.Read("name");
                c.dersKod = file.Read("dersKod").ToString();
                c.saat = int.Parse(file.Read("saat"));
                c.teachers = OgretmenManager.initializeOgretmen( file.Read("tId").Split(','));
                list.AddLast(c);
            }
        }

        public static void Save()
        {
            string str = "";
            foreach(Base_Class.Class c in list)
            {
                str += c.ToString() + "\n";
            }
            MessageBox.Show(str);

            foreach(FileInfo f in new DirectoryInfo(Environment.CurrentDirectory + "\\Classes").GetFiles())
            {
                File.Delete(f.FullName);
            }

            foreach(Base_Class.Class c in list)
            {
                IniFile file = new IniFile(Environment.CurrentDirectory + "\\Classes\\" + c.id.ToString() + ".ini");
                file.Write("name", c.name);
                file.Write("dersKod", c.dersKod);
                file.Write("saat", c.saat.ToString());
                string tId = "";
                foreach(Base_Class.Teacher t in c.teachers)
                {
                    tId += t.id.ToString() + ",";
                }
                file.Write("tId", tId.Substring(0, tId.Length - 1));
               
            }
        }

        public static void AddClass(Base_Class.Class c)
        {
            list.AddLast(c);
        }

        public static void RemoveClass(int id)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Base_Class.Class c = list.ToArray()[i];
                if(c.id == id)
                {
                    list.Remove(c);
                    File.Delete(Environment.CurrentDirectory + "\\Classes\\" + id.ToString() + ".ini");
                    MessageBox.Show(c.ToString());
                    return;
                }
            }
        }

        public static Base_Class.Class[] GetAll()
        {
            return list.ToArray();
        }

        public static Base_Class.Class getClass(int id)
        {
            foreach(Base_Class.Class c in list)
            {
                if(c.id == id)
                {
                    return c;
                }
            }
            return null;
        }


    }
}
