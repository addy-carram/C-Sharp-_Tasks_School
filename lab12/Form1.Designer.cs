namespace lab12
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bibliotecaDataSet = new lab12.BibliotecaDataSet();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carteTableAdapter = new lab12.BibliotecaDataSetTableAdapters.CarteTableAdapter();
            this.chirieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chirieTableAdapter = new lab12.BibliotecaDataSetTableAdapters.ChirieTableAdapter();
            this.cititorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cititorTableAdapter = new lab12.BibliotecaDataSetTableAdapters.CititorTableAdapter();
            this.idcititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chirieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcititorDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cititorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1125, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(954, 731);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 114);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(422, 114);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insereaza";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(422, 114);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sterge ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(422, 114);
            this.button4.TabIndex = 4;
            this.button4.Text = "Actualizeaza";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(77, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 731);
            this.panel1.TabIndex = 5;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaDataSetBindingSource
            // 
            this.bibliotecaDataSetBindingSource.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource.Position = 0;
            // 
            // carteBindingSource
            // 
            this.carteBindingSource.DataMember = "Carte";
            this.carteBindingSource.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // carteTableAdapter
            // 
            this.carteTableAdapter.ClearBeforeFill = true;
            // 
            // chirieBindingSource
            // 
            this.chirieBindingSource.DataMember = "Chirie";
            this.chirieBindingSource.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // chirieTableAdapter
            // 
            this.chirieTableAdapter.ClearBeforeFill = true;
            // 
            // cititorBindingSource
            // 
            this.cititorBindingSource.DataMember = "Cititor";
            this.cititorBindingSource.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // cititorTableAdapter
            // 
            this.cititorTableAdapter.ClearBeforeFill = true;
            // 
            // idcititorDataGridViewTextBoxColumn
            // 
            this.idcititorDataGridViewTextBoxColumn.DataPropertyName = "Id_cititor";
            this.idcititorDataGridViewTextBoxColumn.HeaderText = "Id_cititor";
            this.idcititorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idcititorDataGridViewTextBoxColumn.Name = "idcititorDataGridViewTextBoxColumn";
            this.idcititorDataGridViewTextBoxColumn.Width = 200;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2140, 868);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chirieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource carteBindingSource;
        private BibliotecaDataSetTableAdapters.CarteTableAdapter carteTableAdapter;
        private System.Windows.Forms.BindingSource chirieBindingSource;
        private BibliotecaDataSetTableAdapters.ChirieTableAdapter chirieTableAdapter;
        private System.Windows.Forms.BindingSource cititorBindingSource;
        private BibliotecaDataSetTableAdapters.CititorTableAdapter cititorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
    }
}

