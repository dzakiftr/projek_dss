namespace SPK_WP
{
    partial class Penilaian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penilaian));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.tabPenilaian = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNIK = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblPosisi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_vektor = new System.Windows.Forms.Label();
            this.lbl_bobot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Penilaian_BindingN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabKriteria = new System.Windows.Forms.TabPage();
            this.tabHasil = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rate_pegawai_connected_dataset = new SPK_WP.rate_pegawai_connected_dataset();
            this.ratepegawaiconnecteddatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kriteriaTableAdapter = new SPK_WP.rate_pegawai_connected_datasetTableAdapters.kriteriaTableAdapter();
            this.idkriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPegawaiTableAdapter = new SPK_WP.rate_pegawai_connected_datasetTableAdapters.vPegawaiTableAdapter();
            this.tableAdapterManager = new SPK_WP.rate_pegawai_connected_datasetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPenilaian.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Penilaian_BindingN)).BeginInit();
            this.Penilaian_BindingN.SuspendLayout();
            this.tabKriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_pegawai_connected_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratepegawaiconnecteddatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPegawaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1452, 674);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabPenilaian);
            this.tabControl1.Controls.Add(this.tabKriteria);
            this.tabControl1.Controls.Add(this.tabHasil);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1446, 668);
            this.tabControl1.TabIndex = 2;
            // 
            // tabData
            // 
            this.tabData.Location = new System.Drawing.Point(4, 33);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(1438, 631);
            this.tabData.TabIndex = 3;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // tabPenilaian
            // 
            this.tabPenilaian.Controls.Add(this.tableLayoutPanel1);
            this.tabPenilaian.Controls.Add(this.Penilaian_BindingN);
            this.tabPenilaian.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPenilaian.Location = new System.Drawing.Point(4, 33);
            this.tabPenilaian.Name = "tabPenilaian";
            this.tabPenilaian.Padding = new System.Windows.Forms.Padding(3);
            this.tabPenilaian.Size = new System.Drawing.Size(1438, 631);
            this.tabPenilaian.TabIndex = 0;
            this.tabPenilaian.Text = "Penilaian";
            this.tabPenilaian.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.56145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.43855F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1432, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.95918F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.04082F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblNIK, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblNama, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblPosisi, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.32394F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.38028F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.29578F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(402, 594);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.vPegawaiBindingSource, "Foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(97, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posisi";
            // 
            // lblNIK
            // 
            this.lblNIK.AutoSize = true;
            this.lblNIK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vPegawaiBindingSource, "NIK", true));
            this.lblNIK.Location = new System.Drawing.Point(97, 305);
            this.lblNIK.Name = "lblNIK";
            this.lblNIK.Size = new System.Drawing.Size(55, 19);
            this.lblNIK.TabIndex = 4;
            this.lblNIK.Text = "#NIK#";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vPegawaiBindingSource, "Nama", true));
            this.lblNama.Location = new System.Drawing.Point(97, 339);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(71, 19);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "#Nama#";
            // 
            // lblPosisi
            // 
            this.lblPosisi.AutoSize = true;
            this.lblPosisi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vPegawaiBindingSource, "Posisi", true));
            this.lblPosisi.Location = new System.Drawing.Point(97, 376);
            this.lblPosisi.Name = "lblPosisi";
            this.lblPosisi.Size = new System.Drawing.Size(74, 19);
            this.lblPosisi.TabIndex = 6;
            this.lblPosisi.Text = "#Posisi#";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_vektor);
            this.panel1.Controls.Add(this.lbl_bobot);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(411, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 594);
            this.panel1.TabIndex = 1;
            // 
            // lbl_vektor
            // 
            this.lbl_vektor.AutoSize = true;
            this.lbl_vektor.Location = new System.Drawing.Point(4, 516);
            this.lbl_vektor.Name = "lbl_vektor";
            this.lbl_vektor.Size = new System.Drawing.Size(68, 18);
            this.lbl_vektor.TabIndex = 5;
            this.lbl_vektor.Text = "Vektor S";
            // 
            // lbl_bobot
            // 
            this.lbl_bobot.AutoSize = true;
            this.lbl_bobot.Location = new System.Drawing.Point(4, 486);
            this.lbl_bobot.Name = "lbl_bobot";
            this.lbl_bobot.Size = new System.Drawing.Size(50, 18);
            this.lbl_bobot.TabIndex = 4;
            this.lbl_bobot.Text = "Bobot";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkriteriaDataGridViewTextBoxColumn,
            this.kriteriaDataGridViewTextBoxColumn,
            this.Nilai});
            this.dataGridView1.DataSource = this.ratepegawaiconnecteddatasetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 479);
            this.dataGridView1.TabIndex = 2;
            // 
            // Penilaian_BindingN
            // 
            this.Penilaian_BindingN.AddNewItem = null;
            this.Penilaian_BindingN.CountItem = this.bindingNavigatorCountItem;
            this.Penilaian_BindingN.DeleteItem = null;
            this.Penilaian_BindingN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.Penilaian_BindingN.Location = new System.Drawing.Point(3, 3);
            this.Penilaian_BindingN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Penilaian_BindingN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Penilaian_BindingN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Penilaian_BindingN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Penilaian_BindingN.Name = "Penilaian_BindingN";
            this.Penilaian_BindingN.PositionItem = this.bindingNavigatorPositionItem;
            this.Penilaian_BindingN.Size = new System.Drawing.Size(1432, 25);
            this.Penilaian_BindingN.TabIndex = 0;
            this.Penilaian_BindingN.Text = "bindingNavigator1";
            this.Penilaian_BindingN.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Cari NIK:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tabKriteria
            // 
            this.tabKriteria.Controls.Add(this.dataGridView2);
            this.tabKriteria.Location = new System.Drawing.Point(4, 33);
            this.tabKriteria.Name = "tabKriteria";
            this.tabKriteria.Padding = new System.Windows.Forms.Padding(3);
            this.tabKriteria.Size = new System.Drawing.Size(1438, 631);
            this.tabKriteria.TabIndex = 1;
            this.tabKriteria.Text = "Kriteria";
            this.tabKriteria.UseVisualStyleBackColor = true;
            // 
            // tabHasil
            // 
            this.tabHasil.Location = new System.Drawing.Point(4, 33);
            this.tabHasil.Name = "tabHasil";
            this.tabHasil.Padding = new System.Windows.Forms.Padding(3);
            this.tabHasil.Size = new System.Drawing.Size(1438, 631);
            this.tabHasil.TabIndex = 2;
            this.tabHasil.Text = "Hasil";
            this.tabHasil.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1432, 625);
            this.dataGridView2.TabIndex = 0;
            // 
            // rate_pegawai_connected_dataset
            // 
            this.rate_pegawai_connected_dataset.DataSetName = "rate_pegawai_connected_dataset";
            this.rate_pegawai_connected_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ratepegawaiconnecteddatasetBindingSource
            // 
            this.ratepegawaiconnecteddatasetBindingSource.DataMember = "kriteria";
            this.ratepegawaiconnecteddatasetBindingSource.DataSource = this.rate_pegawai_connected_dataset;
            // 
            // kriteriaTableAdapter
            // 
            this.kriteriaTableAdapter.ClearBeforeFill = true;
            // 
            // idkriteriaDataGridViewTextBoxColumn
            // 
            this.idkriteriaDataGridViewTextBoxColumn.DataPropertyName = "id_kriteria";
            this.idkriteriaDataGridViewTextBoxColumn.FillWeight = 69.51996F;
            this.idkriteriaDataGridViewTextBoxColumn.HeaderText = "No";
            this.idkriteriaDataGridViewTextBoxColumn.Name = "idkriteriaDataGridViewTextBoxColumn";
            this.idkriteriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kriteriaDataGridViewTextBoxColumn
            // 
            this.kriteriaDataGridViewTextBoxColumn.DataPropertyName = "Kriteria";
            this.kriteriaDataGridViewTextBoxColumn.FillWeight = 112.575F;
            this.kriteriaDataGridViewTextBoxColumn.HeaderText = "Kriteria";
            this.kriteriaDataGridViewTextBoxColumn.Name = "kriteriaDataGridViewTextBoxColumn";
            this.kriteriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nilai
            // 
            dataGridViewCellStyle5.NullValue = "0";
            this.Nilai.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nilai.FillWeight = 160.2908F;
            this.Nilai.HeaderText = "Nilai";
            this.Nilai.Name = "Nilai";
            this.Nilai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vPegawaiBindingSource
            // 
            this.vPegawaiBindingSource.DataMember = "vPegawai";
            this.vPegawaiBindingSource.DataSource = this.rate_pegawai_connected_dataset;
            // 
            // vPegawaiTableAdapter
            // 
            this.vPegawaiTableAdapter.ClearBeforeFill = true;
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
            // Penilaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 674);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Penilaian";
            this.Text = "SPK";
            this.Load += new System.EventHandler(this.Penilaian_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPenilaian.ResumeLayout(false);
            this.tabPenilaian.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Penilaian_BindingN)).EndInit();
            this.Penilaian_BindingN.ResumeLayout(false);
            this.Penilaian_BindingN.PerformLayout();
            this.tabKriteria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_pegawai_connected_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratepegawaiconnecteddatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPegawaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabPenilaian;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingNavigator Penilaian_BindingN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabKriteria;
        private System.Windows.Forms.TabPage tabHasil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNIK;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblPosisi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_vektor;
        private System.Windows.Forms.Label lbl_bobot;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource ratepegawaiconnecteddatasetBindingSource;
        private rate_pegawai_connected_dataset rate_pegawai_connected_dataset;
        private rate_pegawai_connected_datasetTableAdapters.kriteriaTableAdapter kriteriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kriteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nilai;
        private System.Windows.Forms.BindingSource vPegawaiBindingSource;
        private rate_pegawai_connected_datasetTableAdapters.vPegawaiTableAdapter vPegawaiTableAdapter;
        private rate_pegawai_connected_datasetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

