using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TrainingPractice_03
{
    public partial class FormBalance : Form
    {
        public const string CONECT = @"Data Source=Leksa\SQLEXPRESS;Initial Catalog=DB_GasStation;Integrated Security=True";
        private SqlConnection myConnection;
        public FormBalance()
        {
            InitializeComponent();
            myConnection = new SqlConnection(CONECT);
            //myConnection.Open();
            //FormBalance_Load(this, null);
        }

        private void FormBalance_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(CONECT);
                myConnection.Open();
                string query = "SELECT        p.Date, p.Volume_BeginDay, p.Volume_Sale, b.Name, b.Price, g.Name\r\nFROM      Balance_Count AS p INNER JOIN\r\n      Types_Fuel AS b ON p.id_fuel = b.ID_fuel\r\nINNER JOIN\r\n    Provider_Directory AS g ON b.id_provider = g.ID_provider";

                var comand = new SqlCommand(query);
                comand.Connection = myConnection;
                var reader = comand.ExecuteReader();
                List<string[]> data = new List<string[]>();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Данные не найдены!");
                }
                else
                {
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    foreach (string[] s in data)
                        dGV.Rows.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void FormBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;

            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 25;
            xlSheet = (Excel.Worksheet)wBook.Sheets[1];
            xlSheet.Name = "Учёт";
            xlApp.Cells[1, 1] = "Дата";
            xlApp.Cells[1, 2] = "Объём на начало дня (л)";
            xlApp.Cells[1, 3] = "Объём продажи (л)";
            xlApp.Cells[1, 4] = "Название топлива";
            xlApp.Cells[1, 5] = "Цена";
            xlApp.Cells[1, 6] = "Поставщик";
            //продолжить 
            for (int i = 0; i < dGV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dGV.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dGV.Rows[i].Cells[j].Value.ToString();
                    xlSheet.Cells.HorizontalAlignment = 2;
                    xlApp.Visible = true;
                }
            }
        }

        private void listBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
        }
        private DataGridViewColumn COL;
        private void btnSort_Click(object sender, EventArgs e)
        {
            COL = new DataGridViewColumn();
            switch (listBoxSort.SelectedIndex)
            {
                case 0: COL = Column1; break;
                case 1: COL = Column2; break;
                case 2: COL = Column3; break;
                case 3: COL = Column4; break;
                case 4: COL = Column5; break;
                case 5: COL = Column6; break;

            }
            if (radioButton1.Checked)
            {
                dGV.Sort(COL, ListSortDirection.Ascending);
            }
            else
            {
                dGV.Sort(COL, ListSortDirection.Descending);
            }
        }
    }
}
