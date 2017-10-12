using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace wifiPasswords
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            MD5 md5Hash = MD5.Create();
            password = GetMd5Hash(md5Hash, password);
            if (login(username, password) != 0)
            {

               

                // Create the XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<login></login>");

                // Add a price element.
                XmlElement newElem = doc.CreateElement("username");
                newElem.InnerText = username;
                doc.DocumentElement.AppendChild(newElem);
                newElem = doc.CreateElement("password");
                newElem.InnerText = password;
                doc.DocumentElement.AppendChild(newElem);

                // Save the document to a file. White space is
                // preserved (no white space).
                doc.PreserveWhitespace = true;
                doc.Save("login.xml");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }else{
                textBoxPassword.Text = "";
                textBoxPassword.Focus();

            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public int login(string username, string password)
        {
            string connectionString = "server=localhost;user=root;database=wifipw;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connectionString);
            int id = 0;
            try
            {
                conn.Open();

                string sql = "SELECT id FROM users WHERE username='"+username+"' AND password='"+password+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id=int.Parse(reader["id"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return id;
        }
    }
}
