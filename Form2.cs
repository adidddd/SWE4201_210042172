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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form1().Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = @"D:\Study\C#\13 March\username.txt";
            string password = @"D:\Study\C#\13 March\password.txt";

           if(File.Exists(username) && File.Exists(password))
            {
                string[] usernames = File.ReadAllLines(username);
                string[] passwords = File.ReadAllLines(password);
           
                for(int i=0; i<usernames.Count(); i++)
                {
                    if (usernames[i]== usertextBox.Text && passwords[i]== passtextBox.Text)
                    {
                        this.Hide();
                        new Form3().Show();
                    }
                }
            }

        }
    }
}
