namespace Home_expenses
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_AddProduct = new System.Windows.Forms.TabPage();
            this.button_List_exit = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.comboBox_type_things = new System.Windows.Forms.ComboBox();
            this.listView_Item = new System.Windows.Forms.ListView();
            this.column_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Total_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_type_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Save = new System.Windows.Forms.Button();
            this.dateTime_of_order = new System.Windows.Forms.DateTimePicker();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountOfProducts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add_product = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Price_product = new System.Windows.Forms.TextBox();
            this.textBox_Name_product = new System.Windows.Forms.TextBox();
            this.tabPage_Select = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button_clear_table = new System.Windows.Forms.Button();
            this.checkBox_day = new System.Windows.Forms.CheckBox();
            this.button_remove_from_db = new System.Windows.Forms.Button();
            this.listView_select = new System.Windows.Forms.ListView();
            this.columnHeader1_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5_Total_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Select_Exit = new System.Windows.Forms.Button();
            this.comboBox_Select_Type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Total_Price_Select = new System.Windows.Forms.TextBox();
            this.checkBox_Mounth = new System.Windows.Forms.CheckBox();
            this.button_Reset_Select = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.dateTimePicker_Select = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_AddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfProducts)).BeginInit();
            this.tabPage_Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSave,
            this.MenuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(98, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(98, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(107, 22);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_AddProduct);
            this.tabControl1.Controls.Add(this.tabPage_Select);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 545);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_AddProduct
            // 
            this.tabPage_AddProduct.BackColor = System.Drawing.Color.White;
            this.tabPage_AddProduct.Controls.Add(this.button_List_exit);
            this.tabPage_AddProduct.Controls.Add(this.button_Remove);
            this.tabPage_AddProduct.Controls.Add(this.comboBox_type_things);
            this.tabPage_AddProduct.Controls.Add(this.listView_Item);
            this.tabPage_AddProduct.Controls.Add(this.button_Save);
            this.tabPage_AddProduct.Controls.Add(this.dateTime_of_order);
            this.tabPage_AddProduct.Controls.Add(this.button_Reset);
            this.tabPage_AddProduct.Controls.Add(this.label6);
            this.tabPage_AddProduct.Controls.Add(this.label5);
            this.tabPage_AddProduct.Controls.Add(this.textBox_TotalPrice);
            this.tabPage_AddProduct.Controls.Add(this.label4);
            this.tabPage_AddProduct.Controls.Add(this.CountOfProducts);
            this.tabPage_AddProduct.Controls.Add(this.label3);
            this.tabPage_AddProduct.Controls.Add(this.button_add_product);
            this.tabPage_AddProduct.Controls.Add(this.label2);
            this.tabPage_AddProduct.Controls.Add(this.label1);
            this.tabPage_AddProduct.Controls.Add(this.textBox_Price_product);
            this.tabPage_AddProduct.Controls.Add(this.textBox_Name_product);
            this.tabPage_AddProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AddProduct.Name = "tabPage_AddProduct";
            this.tabPage_AddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AddProduct.Size = new System.Drawing.Size(915, 519);
            this.tabPage_AddProduct.TabIndex = 0;
            this.tabPage_AddProduct.Text = "Add product";
            // 
            // button_List_exit
            // 
            this.button_List_exit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_List_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_List_exit.Location = new System.Drawing.Point(810, 25);
            this.button_List_exit.Name = "button_List_exit";
            this.button_List_exit.Size = new System.Drawing.Size(60, 23);
            this.button_List_exit.TabIndex = 20;
            this.button_List_exit.Text = "Exit";
            this.button_List_exit.UseVisualStyleBackColor = true;
            this.button_List_exit.Click += new System.EventHandler(this.button_List_exit_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(609, 67);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 19;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // comboBox_type_things
            // 
            this.comboBox_type_things.FormattingEnabled = true;
            this.comboBox_type_things.Items.AddRange(new object[] {
            "Продукти",
            "Одяг/Речі",
            "Дорога",
            "Donation",
            "Заощадження",
            "Медицина",
            "Дозвілля",
            "Комунальні платежі",
            "Гігієна",
            "Побут"});
            this.comboBox_type_things.Location = new System.Drawing.Point(240, 107);
            this.comboBox_type_things.Name = "comboBox_type_things";
            this.comboBox_type_things.Size = new System.Drawing.Size(121, 21);
            this.comboBox_type_things.TabIndex = 18;
            this.comboBox_type_things.Text = "Продукти";
            // 
            // listView_Item
            // 
            this.listView_Item.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_ID,
            this.column_Name,
            this.column_Price,
            this.column_Count,
            this.column_Total_Price,
            this.column_type_Product,
            this.column_date});
            this.listView_Item.FullRowSelect = true;
            this.listView_Item.GridLines = true;
            this.listView_Item.Location = new System.Drawing.Point(8, 170);
            this.listView_Item.Name = "listView_Item";
            this.listView_Item.Size = new System.Drawing.Size(862, 326);
            this.listView_Item.TabIndex = 17;
            this.listView_Item.UseCompatibleStateImageBehavior = false;
            this.listView_Item.View = System.Windows.Forms.View.Details;
            // 
            // column_ID
            // 
            this.column_ID.Text = "ID";
            this.column_ID.Width = 6;
            // 
            // column_Name
            // 
            this.column_Name.Text = "Name";
            this.column_Name.Width = 200;
            // 
            // column_Price
            // 
            this.column_Price.Text = "Price UAH";
            this.column_Price.Width = 87;
            // 
            // column_Count
            // 
            this.column_Count.Text = "Count";
            this.column_Count.Width = 62;
            // 
            // column_Total_Price
            // 
            this.column_Total_Price.Text = "Total_Price UAH";
            this.column_Total_Price.Width = 190;
            // 
            // column_type_Product
            // 
            this.column_type_Product.Text = "Type";
            this.column_type_Product.Width = 145;
            // 
            // column_date
            // 
            this.column_date.Text = "Date";
            this.column_date.Width = 152;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(709, 25);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // dateTime_of_order
            // 
            this.dateTime_of_order.Location = new System.Drawing.Point(15, 108);
            this.dateTime_of_order.Name = "dateTime_of_order";
            this.dateTime_of_order.Size = new System.Drawing.Size(200, 20);
            this.dateTime_of_order.TabIndex = 13;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(709, 67);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 11;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "UAH";
            // 
            // textBox_TotalPrice
            // 
            this.textBox_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_TotalPrice.Location = new System.Drawing.Point(451, 108);
            this.textBox_TotalPrice.Name = "textBox_TotalPrice";
            this.textBox_TotalPrice.ReadOnly = true;
            this.textBox_TotalPrice.Size = new System.Drawing.Size(80, 23);
            this.textBox_TotalPrice.TabIndex = 8;
            this.textBox_TotalPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // CountOfProducts
            // 
            this.CountOfProducts.Location = new System.Drawing.Point(310, 51);
            this.CountOfProducts.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.CountOfProducts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountOfProducts.Name = "CountOfProducts";
            this.CountOfProducts.Size = new System.Drawing.Size(51, 20);
            this.CountOfProducts.TabIndex = 6;
            this.CountOfProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UAH";
            // 
            // button_add_product
            // 
            this.button_add_product.Location = new System.Drawing.Point(609, 24);
            this.button_add_product.Name = "button_add_product";
            this.button_add_product.Size = new System.Drawing.Size(75, 23);
            this.button_add_product.TabIndex = 4;
            this.button_add_product.Text = "Add";
            this.button_add_product.UseVisualStyleBackColor = true;
            this.button_add_product.Click += new System.EventHandler(this.button_add_product_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBox_Price_product
            // 
            this.textBox_Price_product.Location = new System.Drawing.Point(180, 51);
            this.textBox_Price_product.Name = "textBox_Price_product";
            this.textBox_Price_product.Size = new System.Drawing.Size(80, 20);
            this.textBox_Price_product.TabIndex = 1;
            this.textBox_Price_product.Text = "0";
            // 
            // textBox_Name_product
            // 
            this.textBox_Name_product.Location = new System.Drawing.Point(15, 52);
            this.textBox_Name_product.Name = "textBox_Name_product";
            this.textBox_Name_product.Size = new System.Drawing.Size(148, 20);
            this.textBox_Name_product.TabIndex = 0;
            // 
            // tabPage_Select
            // 
            this.tabPage_Select.Controls.Add(this.label9);
            this.tabPage_Select.Controls.Add(this.button_clear_table);
            this.tabPage_Select.Controls.Add(this.checkBox_day);
            this.tabPage_Select.Controls.Add(this.button_remove_from_db);
            this.tabPage_Select.Controls.Add(this.listView_select);
            this.tabPage_Select.Controls.Add(this.button_Select_Exit);
            this.tabPage_Select.Controls.Add(this.comboBox_Select_Type);
            this.tabPage_Select.Controls.Add(this.label7);
            this.tabPage_Select.Controls.Add(this.label8);
            this.tabPage_Select.Controls.Add(this.Total_Price_Select);
            this.tabPage_Select.Controls.Add(this.checkBox_Mounth);
            this.tabPage_Select.Controls.Add(this.button_Reset_Select);
            this.tabPage_Select.Controls.Add(this.button_Select);
            this.tabPage_Select.Controls.Add(this.dateTimePicker_Select);
            this.tabPage_Select.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Select.Name = "tabPage_Select";
            this.tabPage_Select.Size = new System.Drawing.Size(915, 519);
            this.tabPage_Select.TabIndex = 1;
            this.tabPage_Select.Text = "Select";
            this.tabPage_Select.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(764, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "BE CAREFUL!!!";
            // 
            // button_clear_table
            // 
            this.button_clear_table.BackColor = System.Drawing.Color.OrangeRed;
            this.button_clear_table.Location = new System.Drawing.Point(760, 47);
            this.button_clear_table.Name = "button_clear_table";
            this.button_clear_table.Size = new System.Drawing.Size(86, 25);
            this.button_clear_table.TabIndex = 32;
            this.button_clear_table.Text = "Clear table";
            this.button_clear_table.UseVisualStyleBackColor = false;
            this.button_clear_table.Click += new System.EventHandler(this.button_clear_table_Click);
            // 
            // checkBox_day
            // 
            this.checkBox_day.AutoSize = true;
            this.checkBox_day.Checked = true;
            this.checkBox_day.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_day.Location = new System.Drawing.Point(12, 66);
            this.checkBox_day.Name = "checkBox_day";
            this.checkBox_day.Size = new System.Drawing.Size(45, 17);
            this.checkBox_day.TabIndex = 31;
            this.checkBox_day.Text = "Day";
            this.checkBox_day.UseVisualStyleBackColor = true;
            // 
            // button_remove_from_db
            // 
            this.button_remove_from_db.Location = new System.Drawing.Point(649, 49);
            this.button_remove_from_db.Name = "button_remove_from_db";
            this.button_remove_from_db.Size = new System.Drawing.Size(75, 23);
            this.button_remove_from_db.TabIndex = 30;
            this.button_remove_from_db.Text = "Remove";
            this.button_remove_from_db.UseVisualStyleBackColor = true;
            this.button_remove_from_db.Click += new System.EventHandler(this.button_remove_from_db_Click);
            // 
            // listView_select
            // 
            this.listView_select.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1_ID,
            this.columnHeader2_Name,
            this.columnHeader3_Price,
            this.columnHeader4_Count,
            this.columnHeader5_Total_Price,
            this.columnHeader6_Type,
            this.columnHeader7_Date});
            this.listView_select.FullRowSelect = true;
            this.listView_select.GridLines = true;
            this.listView_select.Location = new System.Drawing.Point(6, 89);
            this.listView_select.Name = "listView_select";
            this.listView_select.Size = new System.Drawing.Size(901, 422);
            this.listView_select.TabIndex = 29;
            this.listView_select.UseCompatibleStateImageBehavior = false;
            this.listView_select.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1_ID
            // 
            this.columnHeader1_ID.Text = "ID";
            this.columnHeader1_ID.Width = 6;
            // 
            // columnHeader2_Name
            // 
            this.columnHeader2_Name.Text = "Name";
            this.columnHeader2_Name.Width = 200;
            // 
            // columnHeader3_Price
            // 
            this.columnHeader3_Price.Text = "Price UAH";
            this.columnHeader3_Price.Width = 87;
            // 
            // columnHeader4_Count
            // 
            this.columnHeader4_Count.Text = "Count";
            this.columnHeader4_Count.Width = 62;
            // 
            // columnHeader5_Total_Price
            // 
            this.columnHeader5_Total_Price.Text = "Total_Price UAH";
            this.columnHeader5_Total_Price.Width = 140;
            // 
            // columnHeader6_Type
            // 
            this.columnHeader6_Type.Text = "Type";
            this.columnHeader6_Type.Width = 185;
            // 
            // columnHeader7_Date
            // 
            this.columnHeader7_Date.Text = "Date";
            this.columnHeader7_Date.Width = 198;
            // 
            // button_Select_Exit
            // 
            this.button_Select_Exit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Select_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Select_Exit.Location = new System.Drawing.Point(649, 14);
            this.button_Select_Exit.Name = "button_Select_Exit";
            this.button_Select_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Select_Exit.TabIndex = 28;
            this.button_Select_Exit.Text = "Exit";
            this.button_Select_Exit.UseVisualStyleBackColor = true;
            this.button_Select_Exit.Click += new System.EventHandler(this.button_Select_Exit_Click);
            // 
            // comboBox_Select_Type
            // 
            this.comboBox_Select_Type.FormattingEnabled = true;
            this.comboBox_Select_Type.Items.AddRange(new object[] {
            "Усі покупки",
            "Продукти",
            "Одяг/Речі",
            "Дорога",
            "Donation",
            "Заощадження",
            "Медицина",
            "Дозвілля",
            "Комунальні платежі",
            "Гігієна",
            "Побут"});
            this.comboBox_Select_Type.Location = new System.Drawing.Point(236, 30);
            this.comboBox_Select_Type.Name = "comboBox_Select_Type";
            this.comboBox_Select_Type.Size = new System.Drawing.Size(119, 21);
            this.comboBox_Select_Type.TabIndex = 27;
            this.comboBox_Select_Type.Text = "Усі покупки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Total Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "UAH";
            // 
            // Total_Price_Select
            // 
            this.Total_Price_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total_Price_Select.Location = new System.Drawing.Point(390, 28);
            this.Total_Price_Select.Name = "Total_Price_Select";
            this.Total_Price_Select.ReadOnly = true;
            this.Total_Price_Select.Size = new System.Drawing.Size(80, 23);
            this.Total_Price_Select.TabIndex = 24;
            this.Total_Price_Select.Text = "0";
            // 
            // checkBox_Mounth
            // 
            this.checkBox_Mounth.AutoSize = true;
            this.checkBox_Mounth.Checked = true;
            this.checkBox_Mounth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Mounth.Location = new System.Drawing.Point(63, 66);
            this.checkBox_Mounth.Name = "checkBox_Mounth";
            this.checkBox_Mounth.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Mounth.TabIndex = 23;
            this.checkBox_Mounth.Text = "Mounth";
            this.checkBox_Mounth.UseVisualStyleBackColor = true;
            // 
            // button_Reset_Select
            // 
            this.button_Reset_Select.Location = new System.Drawing.Point(555, 49);
            this.button_Reset_Select.Name = "button_Reset_Select";
            this.button_Reset_Select.Size = new System.Drawing.Size(75, 23);
            this.button_Reset_Select.TabIndex = 22;
            this.button_Reset_Select.Text = "Reset";
            this.button_Reset_Select.UseVisualStyleBackColor = true;
            this.button_Reset_Select.Click += new System.EventHandler(this.button_Reset_Select_Click);
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(555, 14);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(75, 23);
            this.button_Select.TabIndex = 21;
            this.button_Select.Text = "Select";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // dateTimePicker_Select
            // 
            this.dateTimePicker_Select.Location = new System.Drawing.Point(12, 31);
            this.dateTimePicker_Select.Name = "dateTimePicker_Select";
            this.dateTimePicker_Select.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Select.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 569);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Home expenses";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_AddProduct.ResumeLayout(false);
            this.tabPage_AddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfProducts)).EndInit();
            this.tabPage_Select.ResumeLayout(false);
            this.tabPage_Select.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_AddProduct;
        private System.Windows.Forms.Button button_List_exit;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.ComboBox comboBox_type_things;
        private System.Windows.Forms.ListView listView_Item;
        private System.Windows.Forms.ColumnHeader column_Name;
        private System.Windows.Forms.ColumnHeader column_Price;
        private System.Windows.Forms.ColumnHeader column_Count;
        private System.Windows.Forms.ColumnHeader column_Total_Price;
        private System.Windows.Forms.ColumnHeader column_date;
        private System.Windows.Forms.ColumnHeader column_type_Product;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DateTimePicker dateTime_of_order;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CountOfProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Price_product;
        private System.Windows.Forms.TextBox textBox_Name_product;
        private System.Windows.Forms.TabPage tabPage_Select;
        private System.Windows.Forms.Button button_Select_Exit;
        private System.Windows.Forms.ComboBox comboBox_Select_Type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Total_Price_Select;
        private System.Windows.Forms.CheckBox checkBox_Mounth;
        private System.Windows.Forms.Button button_Reset_Select;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Select;
        private System.Windows.Forms.ColumnHeader column_ID;
        private System.Windows.Forms.ListView listView_select;
        private System.Windows.Forms.ColumnHeader columnHeader1_ID;
        private System.Windows.Forms.ColumnHeader columnHeader2_Name;
        private System.Windows.Forms.ColumnHeader columnHeader3_Price;
        private System.Windows.Forms.ColumnHeader columnHeader4_Count;
        private System.Windows.Forms.ColumnHeader columnHeader5_Total_Price;
        private System.Windows.Forms.ColumnHeader columnHeader6_Type;
        private System.Windows.Forms.ColumnHeader columnHeader7_Date;
        private System.Windows.Forms.Button button_remove_from_db;
        private System.Windows.Forms.CheckBox checkBox_day;
        private System.Windows.Forms.Button button_clear_table;
        private System.Windows.Forms.Label label9;
    }
}

