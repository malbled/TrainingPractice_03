using System;
using System.Data;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class FormAddFuel : Form
    {
        public FormAddFuel()
        {
            InitializeComponent();
        }

        private void FormAddFuel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gas_DataSet.Provider_Directory". При необходимости она может быть перемещена или удалена.
            this.provider_DirectoryTableAdapter.Fill(this.gas_DataSet.Provider_Directory);

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
    }
}
