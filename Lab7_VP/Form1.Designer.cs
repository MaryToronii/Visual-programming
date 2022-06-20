
namespace Lab7_VP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSet = new Lab7_VP.BooksDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Genre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Publishing = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Athor = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.allBooksTableAdapter = new Lab7_VP.BooksDataSetTableAdapters.AllBooksTableAdapter();
            this.PIB = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Birht = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.takenBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.22898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.77102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 559);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(6)))));
            this.label3.Location = new System.Drawing.Point(484, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "            History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(6)))));
            this.label2.Location = new System.Drawing.Point(204, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "        About Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(6)))));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "        Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameIDDataGridViewTextBoxColumn,
            this.presentDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.allBooksBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            this.dataGridView1.Location = new System.Drawing.Point(4, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(193, 505);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameIDDataGridViewTextBoxColumn
            // 
            this.nameIDDataGridViewTextBoxColumn.DataPropertyName = "NameID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            this.nameIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameIDDataGridViewTextBoxColumn.HeaderText = "NameID";
            this.nameIDDataGridViewTextBoxColumn.Name = "nameIDDataGridViewTextBoxColumn";
            this.nameIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // presentDataGridViewCheckBoxColumn
            // 
            this.presentDataGridViewCheckBoxColumn.DataPropertyName = "Present";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Olive;
            this.presentDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.presentDataGridViewCheckBoxColumn.HeaderText = "Present";
            this.presentDataGridViewCheckBoxColumn.Name = "presentDataGridViewCheckBoxColumn";
            this.presentDataGridViewCheckBoxColumn.Width = 60;
            // 
            // allBooksBindingSource
            // 
            this.allBooksBindingSource.DataMember = "AllBooks";
            this.allBooksBindingSource.DataSource = this.booksDataSet;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Genre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Publishing);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Cost);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.desc);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.Athor);
            this.panel1.Controls.Add(this.bookName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(204, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 505);
            this.panel1.TabIndex = 4;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Genre.Location = new System.Drawing.Point(125, 219);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(52, 20);
            this.Genre.TabIndex = 10;
            this.Genre.Text = "Жанр";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Жанр";
            // 
            // Publishing
            // 
            this.Publishing.AutoSize = true;
            this.Publishing.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Publishing.Location = new System.Drawing.Point(125, 187);
            this.Publishing.Name = "Publishing";
            this.Publishing.Size = new System.Drawing.Size(104, 20);
            this.Publishing.TabIndex = 8;
            this.Publishing.Text = "Видавництво";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Видавництво";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost.Location = new System.Drawing.Point(125, 154);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(42, 20);
            this.Cost.TabIndex = 6;
            this.Cost.Text = "Ціна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ціна";
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(6, 264);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(268, 145);
            this.desc.TabIndex = 4;
            this.desc.Text = "Description";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(136, 93);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(40, 17);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date";
            // 
            // Athor
            // 
            this.Athor.AutoSize = true;
            this.Athor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Athor.Location = new System.Drawing.Point(136, 62);
            this.Athor.Name = "Athor";
            this.Athor.Size = new System.Drawing.Size(93, 17);
            this.Athor.TabIndex = 2;
            this.Athor.Text = "Athor\'s name";
            // 
            // bookName
            // 
            this.bookName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookName.Location = new System.Drawing.Point(125, 16);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(146, 46);
            this.bookName.TabIndex = 1;
            this.bookName.Text = "bookName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Number);
            this.panel2.Controls.Add(this.Birht);
            this.panel2.Controls.Add(this.Adress);
            this.panel2.Controls.Add(this.PIB);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(484, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 505);
            this.panel2.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Номер";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Дата народження";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Адрес";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "П.І.Б.";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(6)))));
            this.label4.Location = new System.Drawing.Point(0, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "         Reader info";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readerIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.takenBooksBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(273, 285);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // allBooksTableAdapter
            // 
            this.allBooksTableAdapter.ClearBeforeFill = true;
            // 
            // PIB
            // 
            this.PIB.AutoSize = true;
            this.PIB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PIB.Location = new System.Drawing.Point(63, 356);
            this.PIB.Name = "PIB";
            this.PIB.Size = new System.Drawing.Size(35, 17);
            this.PIB.TabIndex = 10;
            this.PIB.Text = "П.І.Б.";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress.Location = new System.Drawing.Point(76, 385);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(48, 17);
            this.Adress.TabIndex = 11;
            this.Adress.Text = "Адрес";
            // 
            // Birht
            // 
            this.Birht.AutoSize = true;
            this.Birht.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birht.Location = new System.Drawing.Point(130, 415);
            this.Birht.Name = "Birht";
            this.Birht.Size = new System.Drawing.Size(116, 17);
            this.Birht.TabIndex = 12;
            this.Birht.Text = "Дата народження";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(65, 444);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(51, 17);
            this.Number.TabIndex = 13;
            this.Number.Text = "Номер";
            // 
            // takenBooksBindingSource
            // 
            this.takenBooksBindingSource.DataSource = typeof(Lab7_VP.TakenBooks);
            // 
            // readerIDDataGridViewTextBoxColumn
            // 
            this.readerIDDataGridViewTextBoxColumn.DataPropertyName = "ReaderID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.readerIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.readerIDDataGridViewTextBoxColumn.HeaderText = "ReaderID";
            this.readerIDDataGridViewTextBoxColumn.Name = "readerIDDataGridViewTextBoxColumn";
            this.readerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.readerIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.startDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 66;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.endDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(757, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Бібліотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenBooksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Publishing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Athor;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource allBooksBindingSource;
        private BooksDataSetTableAdapters.AllBooksTableAdapter allBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource takenBooksBindingSource;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Birht;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label PIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    }
}

