using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace DBXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {

                Daten daten = new Daten();

                daten.NAME = txt_name.Text;
                daten.IDE = txt_ide.Text;
                daten.PROG = txt_prog.Text;
                daten.DBNAME = txt_dbName.Text;
                string datenbank = txt_dbName.Text + ".xml";

                SaveData.SaveDaten(daten, datenbank);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_load_Click(object sender, EventArgs e)
        {
            if (File.Exists(txt_dbName.Text+".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Daten));
                FileStream read = new FileStream(txt_dbName.Text+".xml", FileMode.Open, FileAccess.Read, FileShare.Read) ;

                Daten daten = (Daten)xs.Deserialize(read);

                txt_name.Text = daten.NAME;
                txt_ide.Text = daten.IDE;
                txt_prog.Text = daten.PROG;
                txt_dbName.Text = daten.DBNAME;
                
                
            }
        }

        private void bttn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_ide.Text = "";
            txt_prog.Text = "";
            //txt_dbName.Text = "";
        }
    }
}
