using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainWindow = new MainWindow();
        }
        MainWindow mainWindow;
        
        string User = "Мария";
        string PhoneNumber = "89012345678";
        string Password = "123456";
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string UserName = gunaTextBox1.Text;
            string Number = gunaTextBox2.Text;
            string Pas = gunaTextBox3.Text;
            if (UserName == User && Number == PhoneNumber && Pas == Password)
            {
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Ошибка в логине или пароле.Попробуйте снова!","Ошибка авторизации");

            }
        }

    }
}
