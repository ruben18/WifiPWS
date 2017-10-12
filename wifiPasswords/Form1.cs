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
using System.Security.Cryptography;

using MySql.Data.MySqlClient;

namespace wifiPasswords
{
    public partial class Form1 : Form
    {
        private string[] filesNames;
        private string path = "c:\\wifis";
        private int idUser = 0;
        public Form1()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process=System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\exportWifis.bat");
            while (!process.HasExited)
            {
                
            }

            dataGridView1.Rows.Clear();

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

                sync.Enabled = true;


            }
            
        }

        public void addRow(string ssid, string auth, string pw, DateTime date, int idUser)
        {

            string connectionString = "server=localhost;user=root;database=wifipw;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO networks (ssid, authentication, password, idUSer, created_at, updated_at) VALUES('" + ssid + "','" + auth + "','" + pw + "','"+idUser+"','"+date.ToString()+"','"+date.ToString()+"')";
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
            string filePath = Directory.GetCurrentDirectory() + @"\login.xml";
            if (File.Exists(filePath))
            {
                Console.WriteLine("existe");
                string username="", password="";
                #pragma warning disable CS0618 // Type or member is obsolete
                XmlDataDocument xmldoc = new XmlDataDocument();
                #pragma warning restore CS0618 // Type or member is obsolete
                XmlNodeList xmlnode;
                
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("username");
                if (xmlnode.Count > 0)
                {
                    xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    username = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                }
                xmlnode = xmldoc.GetElementsByTagName("password");
                if (xmlnode.Count > 0)
                {
                    xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    password = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                }
                Login loginClass = new wifiPasswords.Login();
                idUser = loginClass.login(username, password);

                if (idUser != 0)
                {                   
                    DateTime date = DateTime.Now;

                   for (int i = 0; i < dataGridView1.Rows.Count; i++)
                   {
                        string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string type = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string pw = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        if (!verifyWifiExists(name,pw,idUser))
                        {
                            addRow(name, type, pw, date, idUser);
                        }
                   }
                }
            }
            else
            {
                Console.WriteLine("Não existe");

                Login login = new wifiPasswords.Login();
                login.ShowDialog();
            }
            

           
        }

        private bool verifyWifiExists(string name, string pw, int idUser)
        {
            string connectionString = "server=localhost;user=root;database=wifipw;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT id FROM networks WHERE ssid='"+name+"' AND password='"+pw+"' AND idUser='"+idUser+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return false;
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

        

       /* // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        } */

    }
}
