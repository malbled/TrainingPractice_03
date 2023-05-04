using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class FormAddFuel : Form
    {
        public const string CONECT = @"Data Source=Leksa\SQLEXPRESS;Initial Catalog=DB_GasStation;Integrated Security=True";
        private SqlConnection myConnection;
        public FormAddFuel()
        {
            InitializeComponent();
            myConnection = new SqlConnection(CONECT);
        }

        private void FormAddFuel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gas_DataSet.Provider_Directory". При необходимости она может быть перемещена или удалена.
            this.provider_DirectoryTableAdapter.Fill(this.gas_DataSet.Provider_Directory);
            try
            {
                myConnection = new SqlConnection(CONECT);
                myConnection.Open();
                string query = "Select count(*) from Types_Fuel";

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
                    data = data + 101;
                    txtid.Text = data.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int selectedId = ((KeyValuePair<int, string>)cmbprov.SelectedItem).Key;
            FormFuel main = this.Owner as FormFuel;
            this.Close();
            if (main != null)
            {
                DataRow nRow = main.gas_DataSet.Tables[2].NewRow();
                int rc = main.dGVFuel.RowCount + 1;
                nRow[0] = Convert.ToInt32(txtid.Text);
                nRow[1] = txtname.Text;
                nRow[2] = Convert.ToDecimal(txtprice.Text);
                nRow[3] =Convert.ToInt32( cmbprov.Text);

                main.gas_DataSet.Tables[2].Rows.Add(nRow);
                main.types_FuelTableAdapter.Update(main.gas_DataSet.Types_Fuel);
                main.gas_DataSet.Tables[2].AcceptChanges();
                main.dGVFuel.Refresh();
            }
        }

        private void FormAddFuel_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
