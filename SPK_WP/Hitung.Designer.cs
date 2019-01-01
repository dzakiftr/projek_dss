namespace SPK_WP
{
    partial class Hitung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rate_pegawai_connected_dataset = new SPK_WP.rate_pegawai_connected_dataset();
            this.kriteriaTableAdapter = new SPK_WP.rate_pegawai_connected_datasetTableAdapters.kriteriaTableAdapter();
            this.tableAdapterManager = new SPK_WP.rate_pegawai_connected_datasetTableAdapters.TableAdapterManager();
            this.kriteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idkriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perbaikan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_hasil = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_pegawai_connected_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriteriaBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasil Perhitungan";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.74929F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 309);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 37);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkriteriaDataGridViewTextBoxColumn,
            this.kriteriaDataGridViewTextBoxColumn,
            this.bobotDataGridViewTextBoxColumn,
            this.perbaikan});
            this.dataGridView1.DataSource = this.kriteriaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // rate_pegawai_connected_dataset
            // 
            this.rate_pegawai_connected_dataset.DataSetName = "rate_pegawai_connected_dataset";
            this.rate_pegawai_connected_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kriteriaTableAdapter
            // 
            this.kriteriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.kriteriaTableAdapter = this.kriteriaTableAdapter;
            this.tableAdapterManager.pegawaiTableAdapter = null;
            this.tableAdapterManager.penilaianTableAdapter = null;
            this.tableAdapterManager.tb_posisiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SPK_WP.rate_pegawai_connected_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vektor_sTableAdapter = null;
            this.tableAdapterManager.vektor_vTableAdapter = null;
            // 
            // kriteriaBindingSource
            // 
            this.kriteriaBindingSource.DataMember = "kriteria";
            this.kriteriaBindingSource.DataSource = this.rate_pegawai_connected_dataset;
            // 
            // idkriteriaDataGridViewTextBoxColumn
            // 
            this.idkriteriaDataGridViewTextBoxColumn.DataPropertyName = "id_kriteria";
            this.idkriteriaDataGridViewTextBoxColumn.FillWeight = 60.9137F;
            this.idkriteriaDataGridViewTextBoxColumn.HeaderText = "No";
            this.idkriteriaDataGridViewTextBoxColumn.Name = "idkriteriaDataGridViewTextBoxColumn";
            this.idkriteriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kriteriaDataGridViewTextBoxColumn
            // 
            this.kriteriaDataGridViewTextBoxColumn.DataPropertyName = "Kriteria";
            this.kriteriaDataGridViewTextBoxColumn.FillWeight = 113.0288F;
            this.kriteriaDataGridViewTextBoxColumn.HeaderText = "Kriteria";
            this.kriteriaDataGridViewTextBoxColumn.Name = "kriteriaDataGridViewTextBoxColumn";
            this.kriteriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bobotDataGridViewTextBoxColumn
            // 
            this.bobotDataGridViewTextBoxColumn.DataPropertyName = "bobot";
            this.bobotDataGridViewTextBoxColumn.FillWeight = 113.0288F;
            this.bobotDataGridViewTextBoxColumn.HeaderText = "bobot";
            this.bobotDataGridViewTextBoxColumn.Name = "bobotDataGridViewTextBoxColumn";
            this.bobotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perbaikan
            // 
            this.perbaikan.DataPropertyName = "atribut";
            this.perbaikan.FillWeight = 113.0288F;
            this.perbaikan.HeaderText = "perbaikan bobot";
            this.perbaikan.Name = "perbaikan";
            this.perbaikan.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.data_hasil, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(34, 406);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.341825F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.65817F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1045, 341);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 31);
            this.panel2.TabIndex = 0;
            // 
            // data_hasil
            // 
            this.data_hasil.AllowUserToAddRows = false;
            this.data_hasil.AllowUserToDeleteRows = false;
            this.data_hasil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_hasil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_hasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_hasil.Location = new System.Drawing.Point(3, 34);
            this.data_hasil.Name = "data_hasil";
            this.data_hasil.ReadOnly = true;
            this.data_hasil.RowHeadersVisible = false;
            this.data_hasil.Size = new System.Drawing.Size(1039, 304);
            this.data_hasil.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 748);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hitung";
            this.Text = "Hitung";
            this.Load += new System.EventHandler(this.Hitung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_pegawai_connected_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriteriaBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_hasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rate_pegawai_connected_dataset rate_pegawai_connected_dataset;
        private rate_pegawai_connected_datasetTableAdapters.kriteriaTableAdapter kriteriaTableAdapter;
        private rate_pegawai_connected_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource kriteriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perbaikan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView data_hasil;
        private System.Windows.Forms.Button button1;
    }
}