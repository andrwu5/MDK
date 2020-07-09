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
using Xceed.Words.NET;
using Xceed.Document.NET;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace Security_Agency
{
    public partial class Nakladnaya : Form
    {
        private Int32 ID_Nakladnaya;
        public Nakladnaya()
        {
            InitializeComponent();
        }

        private void Nakladnaya_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            //CbFill();
        }

        public string sqlstr = "SELECT " +
            "ID_Nakladnaya, " +
            "Nomer_Nakladnaya as Номер_Накладной " +
            "FROM Nakladnaya";

        private void DgFill()
        {

            //string sqlstr = "SELECT " +
            //"ID_Nakladnaya, " +
            //"Nomer_Nakladnaya as Номер_Накладной " +
            //"FROM Nakladnaya";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }



        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Nakladnaya);
            new Procedure_Class().procedure_Execution("Nakladnaya_delete", arrayList);
            DgFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxNakladnaya.Text);
            new Procedure_Class().procedure_Execution("Nakladnaya_insert", arrayList);
            DgFill();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Nakladnaya);
            arrayList.Add(textBoxNakladnaya.Text);
            new Procedure_Class().procedure_Execution("Nakladnaya_update", arrayList);
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
            Close();
        }

        string extension = string.Empty;
        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        
    }
}
