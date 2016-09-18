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

namespace NCV_EZ_SE
{
    public partial class Form1 : Form
    {
        public static string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(appPath + @"SE\");
            FileInfo[] files = di.GetFiles("*.wav", SearchOption.AllDirectories);

            string SE_list = "";

            foreach (FileInfo f in files)
            {
                string fName = f.Name.Replace(".wav", "");

                SE_list += fName + "\r\n";
            }
            StreamWriter sw = new StreamWriter(appPath + @"SE_list.txt", false);
            sw.Write(SE_list);
            sw.Close();
            MessageBox.Show("Export completed.");
        }
    }
}
