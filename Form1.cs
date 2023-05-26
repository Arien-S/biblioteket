using System.Text.Json.Serialization;

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bibliotek_UI
{
    public partial class Form1 : Form
    {
        private string personalnumber;
        private string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string RegInputNum = RegNum.Text;
            string RegInputPass = RegPass.Text;

            string data = File.ReadAllText(@"C:\Users\arien.sajadi\source\repos\Bibliotek UI\Bibliotek UI\account.json");
            dynamic accountData = JsonConvert.DeserializeObject<dynamic>(data);

            account account = new account(personalnumber, password);


            accountData.Add(JToken.FromObject(RegInputNum));
            

            string dataToSave = JsonConvert.SerializeObject(accountData);
            File.WriteAllText(@"C:\Users\arien.sajadi\source\repos\Bibliotek UI\Bibliotek UI\account.json", dataToSave);



            MessageBox.Show("You entered: " + RegInputNum + RegInputPass);
            Login.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Search_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}