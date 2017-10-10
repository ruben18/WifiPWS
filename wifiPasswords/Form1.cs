using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using MySql.Data.MySqlClient;

namespace wifiPasswords
{
    public partial class Form1 : Form
    {
        private string[] filesNames;
        private string path = "c:\\wifis";

        public Form1()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
           filesNames = Directory.GetFiles(path, "*.xml")
                                     .Select(Path.GetFileName)
                                     .ToArray();



            foreach (string fileName in filesNames) {
                #pragma warning disable CS0618 // Type or member is obsolete
                XmlDataDocument xmldoc = new XmlDataDocument();
                #pragma warning restore CS0618 // Type or member is obsolete
                XmlNodeList xmlnode;
                string name="",pw="", type="";
                FileStream fs = new FileStream(path+"\\"+fileName, FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("name");
                if (xmlnode.Count > 0) { 
                    xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    name = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                }
                xmlnode = xmldoc.GetElementsByTagName("keyMaterial");
                if (xmlnode.Count > 0)
                {
                    xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    pw = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                }

                xmlnode = xmldoc.GetElementsByTagName("authentication");
                if (xmlnode.Count > 0)
                {
                    xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    type = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    
                }
                dataGridView1.Rows.Add(name,type, pw);
                fs.Close();
            }
            
        }

        public void addRow(string ssid, string auth, string pw, DateTime date)
        {

            string connectionString = "server=localhost;user=root;database=wifipw;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO networks (ssid, authentication, password, created_at, updated_at) VALUES('" + ssid + "','" + auth + "','" + pw + "','"+date.ToString()+"','"+date.ToString()+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Added 1 row.");
        }

        private void sync_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string type = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string pw = dataGridView1.Rows[i].Cells[2].Value.ToString();
                addRow(name, type, pw, date);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllWifis();
        }

        private void getAllWifis()
        {

            string connectionString = "server=localhost;user=root;database=wifipw;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT ssid, authentication, password FROM networks";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridViewAllWifis.Rows.Add(reader["ssid"], reader["authentication"], reader["password"]);
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    
    }
}
