namespace SPK_WP
{
    partial class Kriteria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rate_pegawai_connected_dataset = new SPK_WP.rate_pegawai_connected_dataset();
            this.kriteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kriteriaTableAdapter = new SPK_WP.rate_pegawai_connected_datasetTableAdapters.kriteriaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAtribut = new System.Windows.Forms.ComboBox();
            this.txtBobot = new System.Windows.Forms.TextBox();
            this.txtKriteria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idkriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atributDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_pegawai_connected_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriteriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Kriteria";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkriteriaDataGridViewTextBoxColumn,
            this.kriteriaDataGridViewTextBoxColumn,
            this.bobotDataGridViewTextBoxColumn,
            this.atributDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.dataGridView1.DataSource = this.kriteriaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(18, 308);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 377);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rate_pegawai_connected_dataset
            // 
            this.rate_pegawai_connected_dataset.DataSetName = "rate_pegawai_connected_dataset";
            this.rate_pegawai_connected_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kriteriaBindingSource
            // 
            this.kriteriaBindingSource.DataMember = "kriteria";
            this.kriteriaBindingSource.DataSource = this.rate_pegawai_connected_dataset;
            // 
            // kriteriaTableAdapter
            // 
            this.kriteriaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtKriteria);
            this.groupBox1.Controls.Add(this.txtBobot);
            this.groupBox1.Controls.Add(this.cbAtribut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kriteria Baru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Kriteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bobot";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Atribut";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbAtribut
            // 
            this.cbAtribut.FormattingEnabled = true;
            this.cbAtribut.Items.AddRange(new object[] {
            "MAX",
            "MIN"});
            this.cbAtribut.Location = new System.Drawing.Point(187, 117);
            this.cbAtribut.Name = "cbAtribut";
            this.cbAtribut.Size = new System.Drawing.Size(121, 21);
            this.cbAtribut.TabIndex = 1;
            this.cbAtribut.Text = "MAX";
            // 
            // txtBobot
            // 
            this.txtBobot.Location = new System.Drawing.Point(187, 78);
            this.txtBobot.Multiline = true;
            this.txtBobot.Name = "txtBobot";
            this.txtBobot.Size = new System.Drawing.Size(63, 22);
            this.txtBobot.TabIndex = 2;
            // 
            // txtKriteria
            // 
            this.txtKriteria.Location = new System.Drawing.Point(187, 40);
            this.txtKriteria.Multiline = true;
            this.txtKriteria.Name = "txtKriteria";
            this.txtKriteria.Size = new System.Drawing.Size(121, 22);
            this.txtKriteria.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "%";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idkriteriaDataGridViewTextBoxColumn
            // 
            this.idkriteriaDataGridViewTextBoxColumn.DataPropertyName = "id_kriteria";
            this.idkriteriaDataGridViewTextBoxColumn.HeaderText = "No";
            this.idkriteriaDataGridViewTextBoxColumn.Name = "idkriteriaDataGridViewTextBoxColumn";
            this.idkriteriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kriteriaDataGridViewTextBoxColumn
            // 
            this.kriteriaDataGridViewTextBoxColumn.DataPropertyName = "Kriteria";
            this.kriteriaDataGridViewTextBoxColumn.HeaderText = "Kriteria";
            this.kriteriaDataGridViewTextBoxColumn.Name = "kriteriaDataGridViewTextBoxColumn";
            // 
            // bobotDataGridViewTextBoxColumn
            // 
            this.bobotDataGridViewTextBoxColumn.DataPropertyName = "bobot";
            this.bobotDataGridViewTextBoxColumn.HeaderText = "bobot";
            this.bobotDataGridViewTextBoxColumn.Name = "bobotDataGridViewTextBoxColumn";
            // 
            // atributDataGridViewTextBoxColumn
            // 
            this.atributDataGridViewTextBoxColumn.DataPropertyName = "atribut";
            this.atributDataGridViewTextBoxColumn.HeaderText = "atribut";
            this.atributDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "MAX",
            "MIN"});
            this.atributDataGridViewTextBoxColumn.Name = "atributDataGridViewTextBoxColumn";
            this.atributDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.atributDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Kriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kriteria";
            this.Text = "Kriteria";
            this.Load += new System.EventHandler(this.Kriteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_pegawai_connected_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriteriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rate_pegawai_connected_dataset rate_pegawai_connected_dataset;
        private System.Windows.Forms.BindingSource kriteriaBindingSource;
        private rate_pegawai_connected_datasetTableAdapters.kriteriaTableAdapter kriteriaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKriteria;
        private System.Windows.Forms.TextBox txtBobot;
        private System.Windows.Forms.ComboBox cbAtribut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn atributDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}