using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SecurityPanel
{
    public partial class MainWindow : Window
    {
        class SecureCode {
            private string code;

            public SecureCode(string code) {
                this.code = code;
            }

            public string getCode()
            {
                return this.code;
            }

            public void setCode(string code)
            {
                this.code = code;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        // C is pressed, clear security code.
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            pwdBox.Password = "";
        }

        // # is pressed which acts as the enter key.
        private void Button_Click_Hash(object sender, RoutedEventArgs e)
        {
            SecureCode access = new SecureCode(pwdBox.Password);
            DateTime time = DateTime.Now;
            pwdBox.Password = "";

            // If access code is a single digit, display date time and "Restricted Access"
            if (access.getCode().Length == 1)
            {
                access.setCode("Restriced Access\n");
            }

            else if (access.getCode() == "1645" || access.getCode() == "1689")
            {
                access.setCode("Technicians\n");
            }

            else if (access.getCode() == "8345")
            {
                access.setCode("Custodians\n");
            }

            else if (access.getCode() == "9998" || access.getCode() == "1006" || access.getCode() == "1007" || access.getCode() == "1008")
            {
                access.setCode("Scientists\n");
            }

            else
            {
                access.setCode("Access Denied\n");
            }

            accessLog.Text += time.ToString("F") + " " + access.getCode();
        }

        // Update the digit pressed into the PasswordBox.
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += '0';
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += '1';
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            pwdBox.Password += "9";
        }
    }
}