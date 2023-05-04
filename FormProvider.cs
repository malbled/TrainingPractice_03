using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class FormProvider : Form
    {
        public const string CONECT = @"Data Source=Leksa\SQLEXPRESS;Initial Catalog=DB_GasStation;Integrated Security=True";
        private SqlConnection myConnection;
        public FormProvider()
        {
            InitializeComponent();
            myConnection = new SqlConnection(CONECT);
        }

        private void FormProvider_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gas_DataSet.Provider_Directory". При необходимости она может быть перемещена или удалена.
            this.provider_DirectoryTableAdapter.Fill(this.gas_DataSet.Provider_Directory);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceTablProv.EndEdit();
            this.provider_DirectoryTableAdapter.Update(this.gas_DataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(CONECT);
                myConnection.Open();
                string query = "Select count(*) from Provider_Directory";

                var comand = new SqlCommand(query);
                comand.Connection = myConnection;
                var reader = comand.ExecuteReader();
                int data = 0;
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Что-то неполучается!");
                }
                else
                {
                    while (reader.Read())
                    {
                        data = reader.GetInt32(0);
                    }
                    dGVProvider.Rows[data].Cells[0].Value = data+1;
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

        private void FormProvider_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
