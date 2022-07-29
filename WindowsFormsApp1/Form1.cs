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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Anket formu düzəldin, həmin formu json seriallaşdırın, və hazır anketləri
        // deseriallaşdırıb yenidən forma qaytarın.Anketi save edərkən, .json faylın
        //  adı anket müəllifinin adı ilə eyni olmalıdır.
        string question1;
        string question2;
        string question3;
        string question4;
        string question5;
      

        private void Send_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = textBox1.Text;
            user.SurName= textBox2.Text;
            user.Email= textBox3.Text;
            user.PhoneNumber = maskedTextBox1.Text;
            user.Age = textBox5.Text;
            user.Yemek = question1;
            user.Gezinti = question2;
            user.Maraqli = question3;
            user.Qiymet = question4;
            user.HeyvanlarinSayi = question5;
            FileHelper.WriteToFile(user);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question1 = "BAD";
                        else if (i == 1) question1 = "AVERAGE";
                        else if (i == 2) question1 = "GOOD";
                        else if (i == 3) question1 = "EXCELLENT";
                    }

                }
            }

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if (groupBox2.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question2 = "BAD";
                        else if (i == 1) question2 = "AVERAGE";
                        else if (i == 2) question2 = "GOOD";
                        else if (i == 3) question2 = "EXCELLENT";
                    }

                }
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox3.Controls.Count; i++)
            {
                if (groupBox3.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question3 = "BAD";
                        else if (i == 1) question3 = "AVERAGE";
                        else if (i == 2) question3 = "GOOD";
                        else if (i == 3) question3 = "EXCELLENT";
                    }

                }
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox4.Controls.Count; i++)
            {
                if (groupBox4.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question4 = "BAD";
                        else if (i == 1) question4 = "AVERAGE";
                        else if (i == 2) question4 = "GOOD";
                        else if (i == 3) question4 = "EXCELLENT";
                    }

                }
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox5.Controls.Count; i++)
            {
                if (groupBox5.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question5 = "BAD";
                        else if (i == 1) question5 = "AVERAGE";
                        else if (i == 2) question5 = "GOOD";
                        else if (i == 3) question5 = "EXCELLENT";
                    }

                }
            }
        }


    }
}
