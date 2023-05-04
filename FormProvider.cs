using System;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class FormProvider : Form
    {
        int i = 4;
        public FormProvider()
        {
            InitializeComponent();
            
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
            dGVProvider.Rows[i].Cells[0].Value = i + 1;
            i++;
        }
    }
}
