using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            AdTXB.Text = "Ad";
            SoyadTXB.Text = "Soyad";
            EmailTXB.Text = "name@example.com";
            TelTXB.Text = "+994551234567";
           // DogumTXB.Text = "yyyy/dd/MM";


            AdTXB.ForeColor = Color.Gray;
            SoyadTXB.ForeColor = Color.Gray;
            EmailTXB.ForeColor = Color.Gray;
            TelTXB.ForeColor = Color.Gray;
          //  DogumTXB.ForeColor = Color.Gray;

        }
      
        private void ElaveEtB_Click(object sender, EventArgs e)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex.IsMatch(EmailTXB.Text, pattern);
            string Pattern = @"^\+994(55|51|55|70|77)([0-9]){7}$";
            Regex.IsMatch(TelTXB.Text, Pattern);
            //   bool a= DateTime.TryParse(DogumTXB.Text, out DateTime date1);
            if (Regex.IsMatch(TelTXB.Text, Pattern) & Regex.IsMatch(EmailTXB.Text, pattern) & AdTXB.Text != string.Empty & SoyadTXB.Text != string.Empty & TelTXB.Text != string.Empty & EmailTXB.Text != string.Empty)
            {
                if (AdTXB.ForeColor != Color.Gray & SoyadTXB.ForeColor != Color.Gray & EmailTXB.ForeColor != Color.Gray & TelTXB.ForeColor != Color.Gray)
                {


                    User user = new User();
                    user.Ad = AdTXB.Text;
                    user.Soyad = TelTXB.Text;
                    user.Email = EmailTXB.Text;
                    user.Tel = TelTXB.Text;
                    user.Dogum = dateTimePicker1.Text;
                    users.Add(user);
                    listBox1.DataSource = null;
                    listBox1.DataSource = users;
                    listBox1.DisplayMember = "Ad";
                    // MessageBox.Show(listBox1.Items.Count.ToString());
                    AdTXB.Text = string.Empty;
                    SoyadTXB.Text = string.Empty;
                    EmailTXB.Text = string.Empty;
                    TelTXB.Text = string.Empty;
                    dateTimePicker1.Text = string.Empty;
                }
            }
            
                if (!Regex.IsMatch(TelTXB.Text, Pattern) | TelTXB.ForeColor == Color.Gray)
                {
                    MessageBox.Show("Error Tel");
                }
                if (!Regex.IsMatch(EmailTXB.Text, pattern) | EmailTXB.ForeColor == Color.Gray)
                {
                    MessageBox.Show("Error Email");
                }
                if (AdTXB.Text == string.Empty | AdTXB.ForeColor == Color.Gray)
                {
                    MessageBox.Show("Empty Ad");
                }
                if (SoyadTXB.Text == string.Empty | SoyadTXB.ForeColor == Color.Gray)
                {
                    MessageBox.Show("Soyad empty");
                }
                if (dateTimePicker1.Text == string.Empty)
                {
                    MessageBox.Show("Error Date");
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(FileNameTXB.Text!=string.Empty & listBox1.DataSource !=null)
            {

               string json = JsonConvert.SerializeObject(users);
                System.IO.File.WriteAllText($"{FileNameTXB.Text}.json", json);
                FileNameTXB.Text = string.Empty;
                AdTXB.Text = string.Empty;
                SoyadTXB.Text = string.Empty;
                EmailTXB.Text = string.Empty;
                TelTXB.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
                listBox1.DataSource = null;
                listBox1.ClearSelected();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{FileNameTXB.Text}.json"))
            {
                listBox1.DataSource = null;
                listBox1.ClearSelected();
                string str = File.ReadAllText($"{FileNameTXB.Text}.json");
                var obj = JsonConvert.DeserializeObject<User[]>(str);
                FileNameTXB.Text = string.Empty;
                users.Clear();
                for (int i = 0; i < obj.Length; i++)
                {
                users.Add(obj[i]);

                }
                listBox1.ClearSelected();
                listBox1.DataSource = users;
                listBox1.DisplayMember = "Ad";

            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ElaveEtB.Enabled = false;
            DeyisB.Enabled = true;
            AdTXB.ForeColor = Color.Black;
            SoyadTXB.ForeColor = Color.Black;
            EmailTXB.ForeColor = Color.Black;
            TelTXB.ForeColor = Color.Black;
           // DogumTXB.ForeColor = Color.Black;
            AdTXB.Text = users[listBox1.SelectedIndex].Ad;
            SoyadTXB.Text = users[listBox1.SelectedIndex].Soyad;
            EmailTXB.Text = users[listBox1.SelectedIndex].Email;
            TelTXB.Text = users[listBox1.SelectedIndex].Tel;
            dateTimePicker1.Text = users[listBox1.SelectedIndex].Dogum;
        }

        private void DeyisB_Click(object sender, EventArgs e)
        {
            ElaveEtB.Enabled = true;
            DeyisB.Enabled = false;
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex.IsMatch(EmailTXB.Text, pattern);
            string Pattern = @"^\+994(55|51|55|70|77)([0-9]){7}$";
            Regex.IsMatch(TelTXB.Text, Pattern);
            //   bool a= DateTime.TryParse(DogumTXB.Text, out DateTime date1);
            if (Regex.IsMatch(TelTXB.Text, Pattern) & Regex.IsMatch(EmailTXB.Text, pattern) & AdTXB.Text != string.Empty & SoyadTXB.Text != string.Empty & TelTXB.Text != string.Empty & EmailTXB.Text != string.Empty)
            {
                if (AdTXB.ForeColor != Color.Gray & SoyadTXB.ForeColor != Color.Gray & EmailTXB.ForeColor != Color.Gray & TelTXB.ForeColor != Color.Gray)
                {

                    ElaveEtB.Enabled = true;
                    DeyisB.Enabled = false;
                    users[listBox1.SelectedIndex].Ad = AdTXB.Text;
                    users[listBox1.SelectedIndex].Soyad = SoyadTXB.Text;
                    users[listBox1.SelectedIndex].Email = EmailTXB.Text;
                    users[listBox1.SelectedIndex].Tel = TelTXB.Text;
                    users[listBox1.SelectedIndex].Dogum = dateTimePicker1.Text;
                    listBox1.DataSource = null;
                    listBox1.DataSource = users;
                    listBox1.DisplayMember = "Ad";

                    AdTXB.Text = string.Empty;
                    SoyadTXB.Text = string.Empty;
                    EmailTXB.Text = string.Empty;
                    TelTXB.Text = string.Empty;
                    dateTimePicker1.Text = string.Empty;
                }
            }

            if (!Regex.IsMatch(TelTXB.Text, Pattern) | TelTXB.ForeColor == Color.Gray)
            {
                MessageBox.Show("Error Tel");
            }
            if (!Regex.IsMatch(EmailTXB.Text, pattern) | EmailTXB.ForeColor == Color.Gray)
            {
                MessageBox.Show("Error Email");
            }
            if (AdTXB.Text == string.Empty | AdTXB.ForeColor == Color.Gray)
            {
                MessageBox.Show("Empty Ad");
            }
            if (SoyadTXB.Text == string.Empty | SoyadTXB.ForeColor == Color.Gray)
            {
                MessageBox.Show("Soyad empty");
            }
            if (dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("Error Date");
            }







            //
          
            AdTXB.Text = string.Empty;
            SoyadTXB.Text = string.Empty;
            EmailTXB.Text = string.Empty;
            TelTXB.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            AdTXB.ForeColor = Color.Gray;
            SoyadTXB.ForeColor = Color.Gray;
            EmailTXB.ForeColor = Color.Gray;
            TelTXB.ForeColor = Color.Gray;
            dateTimePicker1.ForeColor = Color.Gray;
            AdTXB.Text = "Ad";
            SoyadTXB.Text = "Soyad";
            EmailTXB.Text = "name@example.com";
            TelTXB.Text = "+994551234567";
            //da.Text = "12.23.2020";
        }

       

       

       

        private void DogumTXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdTXB_Enter(object sender, EventArgs e)
        {
            AdTXB.ForeColor = Color.Black;
            if (AdTXB.Text == "Ad")
            {


                AdTXB.Text = string.Empty;
            }
        }

        private void AdTXB_Leave(object sender, EventArgs e)
        {
            if (AdTXB.Text == string.Empty || AdTXB.Text == "Ad")
            {
                AdTXB.ForeColor = Color.Gray;
                AdTXB.Text = "Ad";
            }
        }

        private void SoyadTXB_Enter(object sender, EventArgs e)
        {
            SoyadTXB.ForeColor = Color.Black;
            if (SoyadTXB.Text == "Soyad")
            {


                SoyadTXB.Text = string.Empty;
            }
        }

        private void SoyadTXB_Leave(object sender, EventArgs e)
        {
            if (SoyadTXB.Text == string.Empty || SoyadTXB.Text == "Soyad")
            {
                SoyadTXB.ForeColor = Color.Gray;
                SoyadTXB.Text = "Soyad";
            }
        }

        private void EmailTXB_Enter(object sender, EventArgs e)
        {
            EmailTXB.ForeColor = Color.Black;
            if (EmailTXB.Text == "name@example.com")
            {

                EmailTXB.Text = string.Empty;
            }
        }

        private void EmailTXB_Leave(object sender, EventArgs e)
        {
            if (EmailTXB.Text == string.Empty || EmailTXB.Text == "name@example.com")
            {
                EmailTXB.ForeColor = Color.Gray;
                EmailTXB.Text = "name@example.com";
            }
        }

        private void TelTXB_Enter(object sender, EventArgs e)
        {
            TelTXB.ForeColor = Color.Black;
            if (TelTXB.Text == "+994551234567")
            {

                TelTXB.Text = string.Empty;
            }
        }

        private void TelTXB_Leave(object sender, EventArgs e)
        {

            if (TelTXB.Text == string.Empty || TelTXB.Text == "+994551234567")
            {
                TelTXB.ForeColor = Color.Gray;
                TelTXB.Text = "+994551234567";
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
