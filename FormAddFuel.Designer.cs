namespace TrainingPractice_03
{
    partial class FormAddFuel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddFuel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.MaskedTextBox();
            this.cmbprov = new System.Windows.Forms.ComboBox();
            this.providerDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gas_DataSet = new TrainingPractice_03.Gas_DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.provider_DirectoryTableAdapter = new TrainingPractice_03.Gas_DataSetTableAdapters.Provider_DirectoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.providerDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Поставщик";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtid.Location = new System.Drawing.Point(139, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(146, 29);
            this.txtid.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtname.Location = new System.Drawing.Point(139, 107);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(216, 29);
            this.txtname.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtprice.Location = new System.Drawing.Point(139, 158);
            this.txtprice.Mask = "##.###";
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(216, 29);
            this.txtprice.TabIndex = 6;
            // 
            // cmbprov
            // 
            this.cmbprov.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbprov.DataSource = this.providerDirectoryBindingSource;
            this.cmbprov.DisplayMember = "ID_provider";
            this.cmbprov.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbprov.FormattingEnabled = true;
            this.cmbprov.Location = new System.Drawing.Point(139, 214);
            this.cmbprov.Name = "cmbprov";
            this.cmbprov.Size = new System.Drawing.Size(216, 29);
            this.cmbprov.TabIndex = 7;
            this.cmbprov.ValueMember = "ID_provider";
            // 
            // providerDirectoryBindingSource
            // 
            this.providerDirectoryBindingSource.DataMember = "Provider_Directory";
            this.providerDirectoryBindingSource.DataSource = this.gas_DataSet;
            // 
            // gas_DataSet
            // 
            this.gas_DataSet.DataSetName = "Gas_DataSet";
            this.gas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(103, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(240, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // provider_DirectoryTableAdapter
            // 
            this.provider_DirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(418, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbprov);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddFuel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление топлива";
            this.Load += new System.EventHandler(this.FormAddFuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.MaskedTextBox txtprice;
        private System.Windows.Forms.ComboBox cmbprov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Gas_DataSet gas_DataSet;
        private System.Windows.Forms.BindingSource providerDirectoryBindingSource;
        private Gas_DataSetTableAdapters.Provider_DirectoryTableAdapter provider_DirectoryTableAdapter;
    }
}