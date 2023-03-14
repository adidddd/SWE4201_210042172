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

namespace _13_March
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form2().Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = @"D:\Study\C#\13 March\name.txt";
            string username = @"D:\Study\C#\13 March\username.txt";
            string password= @"D:\Study\C#\13 March\password.txt";


            using (StreamWriter writer = new StreamWriter(name))
            {
                writer.Write(nametextBox.Text);
            }
            File.AppendAllText(username, Environment.NewLine + usernametextBox.Text);
            File.AppendAllText(password, Environment.NewLine + passwordtextBox.Text);

            MessageBox.Show($"Account Successfully created for user {nametextBox.Text}");


        }
    }
}
