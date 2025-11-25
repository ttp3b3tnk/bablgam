namespace alimozavr
{
    partial class Form2
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
            this.fafafakDataSet = new alimozavr.fafafakDataSet();
            this.materialtypeimportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.material_type_importTableAdapter = new alimozavr.fafafakDataSetTableAdapters.Material_type_importTableAdapter();
            this.tipmaterialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentbrakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fafafakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialtypeimportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipmaterialaDataGridViewTextBoxColumn,
            this.procentbrakaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialtypeimportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(184, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // fafafakDataSet
            // 
            this.fafafakDataSet.DataSetName = "fafafakDataSet";
            this.fafafakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialtypeimportBindingSource
            // 
            this.materialtypeimportBindingSource.DataMember = "Material_type_import";
            this.materialtypeimportBindingSource.DataSource = this.fafafakDataSet;
            // 
            // material_type_importTableAdapter
            // 
            this.material_type_importTableAdapter.ClearBeforeFill = true;
            // 
            // tipmaterialaDataGridViewTextBoxColumn
            // 
            this.tipmaterialaDataGridViewTextBoxColumn.DataPropertyName = "tip_materiala";
            this.tipmaterialaDataGridViewTextBoxColumn.HeaderText = "tip_materiala";
            this.tipmaterialaDataGridViewTextBoxColumn.Name = "tipmaterialaDataGridViewTextBoxColumn";
            // 
            // procentbrakaDataGridViewTextBoxColumn
            // 
            this.procentbrakaDataGridViewTextBoxColumn.DataPropertyName = "procent_braka";
            this.procentbrakaDataGridViewTextBoxColumn.HeaderText = "procent_braka";
            this.procentbrakaDataGridViewTextBoxColumn.Name = "procentbrakaDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "knopo4ka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fafafakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialtypeimportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private fafafakDataSet fafafakDataSet;
        private System.Windows.Forms.BindingSource materialtypeimportBindingSource;
        private fafafakDataSetTableAdapters.Material_type_importTableAdapter material_type_importTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipmaterialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentbrakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}