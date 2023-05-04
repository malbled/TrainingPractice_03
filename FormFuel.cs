using System;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class FormFuel : Form
    {
        public FormFuel()
        {
            InitializeComponent();
        }

        private void FormFuel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gas_DataSet.Types_Fuel". При необходимости она может быть перемещена или удалена.
            this.types_FuelTableAdapter.Fill(this.gas_DataSet.Types_Fuel);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAddFuel formAddFuel = new FormAddFuel();
            formAddFuel.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSourceTablFuel.Filter = "Price <='" +Convert.ToDecimal( txtprice.Text) + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSourceTablFuel.Filter = "";
            txtprice.Text = "";
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSourceTablFuel.EndEdit();
            this.types_FuelTableAdapter.Update(this.gas_DataSet);
        }
    }
}
