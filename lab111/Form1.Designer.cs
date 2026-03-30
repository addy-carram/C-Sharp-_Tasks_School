namespace lab111
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comoanie_ITDataSet = new lab111.Comoanie_ITDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.angajatiTableAdapter = new lab111.Comoanie_ITDataSetTableAdapters.AngajatiTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comoanie_ITDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.salariuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(770, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 772);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.comoanie_ITDataSet;
            // 
            // comoanie_ITDataSet
            // 
            this.comoanie_ITDataSet.DataSetName = "Comoanie_ITDataSet";
            this.comoanie_ITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(691, 112);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(691, 112);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inserare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdAngajat";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 200;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.Width = 200;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 200;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 200;
            // 
            // salariuDataGridViewTextBoxColumn
            // 
            this.salariuDataGridViewTextBoxColumn.DataPropertyName = "Salariu";
            this.salariuDataGridViewTextBoxColumn.HeaderText = "Salariu";
            this.salariuDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salariuDataGridViewTextBoxColumn.Name = "salariuDataGridViewTextBoxColumn";
            this.salariuDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2060, 915);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comoanie_ITDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Comoanie_ITDataSet comoanie_ITDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private Comoanie_ITDataSetTableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuDataGridViewTextBoxColumn;
    }
}

