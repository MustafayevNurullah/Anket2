using Newtonsoft.Json;
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

namespace WindowsFormsApp7
{



    public partial class Form1 : Form
    {

        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Name";
            DeyisB.Enabled = false;
          
        }
      
        private void ElaveEtB_Click(object sender, EventArgs e)
        {
            bool b = Int32.TryParse(TelTXB.Text, out int t);
            if (b & AdTXB.Text != string.Empty & SoyadTXB.Text != string.Empty & TelTXB.Text != string.Empty & EmailTXB.Text != string.Empty & DogumTXB.Text != string.Empty)
            {
                User user = new User();
                user.Ad = AdTXB.Text;
                user.Soyad = TelTXB.Text;
                user.Email = EmailTXB.Text;
                user.Tel = TelTXB.Text;
                user.Dogum = DogumTXB.Text;
                users.Add(user);
                    
                listBox1.DataSource =users;
                listBox1.DisplayMember = "Ad";
                
                AdTXB.Text = string.Empty;
                SoyadTXB.Text = string.Empty;
                EmailTXB.Text = string.Empty;
                TelTXB.Text = string.Empty;
                DogumTXB.Text = string.Empty;
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElaveEtB.Enabled = false;
            DeyisB.Enabled = true;
            AdTXB.Text = users[listBox1.SelectedIndex].Ad;
            SoyadTXB.Text = users[listBox1.SelectedIndex].Soyad;
            EmailTXB.Text = users[listBox1.SelectedIndex].Email;
            TelTXB.Text = users[listBox1.SelectedIndex].Tel;
            DogumTXB.Text = users[listBox1.SelectedIndex].Dogum;
        }

        private void DeyisB_Click(object sender, EventArgs e)
        {
            bool a = Int32.TryParse(TelTXB.Text, out int b);
            if (a & AdTXB.Text != string.Empty & SoyadTXB.Text != string.Empty & TelTXB.Text != string.Empty & EmailTXB.Text != string.Empty & DogumTXB.Text != string.Empty)
            {
                ElaveEtB.Enabled = true;
                DeyisB.Enabled = false;
                users[listBox1.SelectedIndex].Ad = AdTXB.Text;
                users[listBox1.SelectedIndex].Soyad = SoyadTXB.Text;
                users[listBox1.SelectedIndex].Email = EmailTXB.Text;
                users[listBox1.SelectedIndex].Tel = TelTXB.Text;
                users[listBox1.SelectedIndex].Dogum = DogumTXB.Text;
                AdTXB.Text = string.Empty;
                SoyadTXB.Text = string.Empty;
                EmailTXB.Text = string.Empty;
                TelTXB.Text = string.Empty;
                DogumTXB.Text = string.Empty;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(FileNameTXB.Text!=string.Empty)
            {
                string json = JsonConvert.SerializeObject(users);
                System.IO.File.WriteAllText($"{FileNameTXB.Text}.json", json);
                FileNameTXB.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{FileNameTXB.Text}.json"))
            {
                string str = File.ReadAllText($"{FileNameTXB.Text}.json");
                var obj = JsonConvert.DeserializeObject<User>(str);
                FileNameTXB.Text = string.Empty;
                users.Clear();
                users.Add(obj);
                listBox1.ClearSelected();
                listBox1.DataSource = users;
            }
        }
    }
    class User
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Dogum { get; set; }

    }
}
