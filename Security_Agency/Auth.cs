using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Agency
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            

            //Проверка на заполнение полей вводав
            switch (tbUser_Login.Text == "")
            {
                case true:
                    tbUser_Login.BackColor = Color.Red;
                    break;
                case false:
                    switch (tbUser_Password.Text == "")
                    {
                        case true:
                            tbUser_Password.BackColor = Color.Red;
                            break;
                        case false:
                            Function_Class function = new Function_Class();
                            //Прохождение авторизации
                            function.Authorization(tbUser_Login.Text,
                                tbUser_Password.Text);
                            switch (Program.intID == null)
                            {
                                //Не верно введёные данные
                                case true:
                                    MessageBox.Show("Введённые данные не верны! " +
                                        "Повторите ввод!",
                                               "Охранное агентство", MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                                    tbUser_Login.Clear();
                                    tbUser_Password.Clear();
                                    tbUser_Login.Focus();
                                    break;
                                case false:
                                    //Проверка на блокировку учётной записи
                                    switch (Program.intDropStatis)
                                    {
                                        case 1:
                                            MessageBox.Show("Вы временно заблокированы " +
                                                "в системе!\nОбратитесь к администратору!",
                                                "Охранное агентство", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                            break;
                                        case 0:
                                            //Какого типа учётная запись сотрудник или клиент
                                            switch (Program.strStatus)
                                            {
                                                case "Klient":
                                                    Profile_Klient profile_Klient
                                                        = new Profile_Klient();
                                                    profile_Klient.Show(this);
                                                    Hide();
                                                    break;
                                                case "Employee":
                                                    Profile_Employee Profile_Employee
                                                        = new Profile_Employee();
                                                    Profile_Employee.Show(this);
                                                    Hide();
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            new ConnectionForm().Show();
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            Visible = false;
            ShowInTaskbar = false;
        }
    }
}
