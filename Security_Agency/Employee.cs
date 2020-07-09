using System;
using System.Collections;
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
    public partial class EmployeeForm : Form
    {
        private Int32 ID_Employee = -1;
        //private Table_Class tableClass;
        public EmployeeForm()
        {
            InitializeComponent();


            //comboBoxPosition.Item

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
           // CbFill();
        }



        private void DgFill()
        {

            string sqlstr = "SELECT " +
            "ID_Employee, " +
            "First_Name_Employee as Фамилия, " +
            "Name_Employee as Имя, " +
            "Middle_Name_Employee as Отчество, " +
            "Position as Должность, " +
            "Employee_Login as Логин_сотрудника, " +
            "Employee_Password as Пароль_сотрудника, " +
            "Employee_Logical_Delete as Удаление " +
            "FROM [dbo].[Employee]";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
            //var v = table_class.table.Rows[3].ItemArray[3];
            dataGridView1.Columns[0].Visible = false;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Employee = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Employee);
            new Procedure_Class().procedure_Execution("Employee_delete", arrayList);
            DgFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxFirstName.Text);
            arrayList.Add(textBoxName.Text);
            arrayList.Add(textBoxMiddleName.Text);
            arrayList.Add(textBoxLogin.Text);
            arrayList.Add(textBoxPassword.Text);
            arrayList.Add(textBoxPosition.Text);
            arrayList.Add(1);
            new Procedure_Class().procedure_Execution("Employee_insert", arrayList);
            DgFill();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ID_Employee == -1)
            {
                MessageBox.Show("No select!");
                return;

            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Employee);
            arrayList.Add(textBoxFirstName.Text);
            arrayList.Add(textBoxName.Text);
            arrayList.Add(textBoxMiddleName.Text);
            arrayList.Add(textBoxLogin.Text);
            arrayList.Add(textBoxPassword.Text);
            arrayList.Add(textBoxPosition.Text);
            
            arrayList.Add(1);
            new Procedure_Class().procedure_Execution("Employee_update", arrayList);
            DgFill();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.White)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                }

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DgFill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            Visible = true;
            ShowInTaskbar = true;
        }



       
    }
}
