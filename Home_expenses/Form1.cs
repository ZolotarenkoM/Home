using System;
using System.Windows.Forms;
using System.Globalization;
using Domain;
using Session;

namespace Home_expenses
{
    /// <summary>
    /// Class where implement all operations on items
    /// </summary>
    public partial class Form1 : Form
    {
        internal Log MyLog = new Log();
        public static string login;
        Operation op = new Operation();
        internal string type;
        internal bool day = false;
        internal bool mounth = false;
        internal DateTime date = DateTime.Now;
        double price;

        public Form1()
        {
            InitializeComponent();
            textBox_Name_product.Text = @"Продукти";
        }

        private void button_List_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Select_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Method for Add some product to listView (not database)
        /// </summary>
        private void button_add_product_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_Name_product.Text))
                {
                    price += Convert.ToDouble(textBox_Price_product.Text) * Convert.ToDouble(CountOfProducts.Value);
                    textBox_TotalPrice.Text = price.ToString();
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(textBox_Name_product.Text);
                    lvi.SubItems.Add(textBox_Price_product.Text);
                    lvi.SubItems.Add(CountOfProducts.Text);
                    lvi.SubItems.Add((Convert.ToDouble(textBox_Price_product.Text) * Convert.ToInt32(CountOfProducts.Value)).ToString());
                    lvi.SubItems.Add(comboBox_type_things.Text);
                    lvi.SubItems.Add(string.Format(dateTime_of_order.Text));
                    listView_Item.Items.Add(lvi);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Wrong format");
                MyLog.Write(@"Filing an incorrect format");
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
                MyLog.Write(ob.Message);
            }
            finally
            {
                textBox_Price_product.Text = @"0";
                textBox_Name_product.Text = comboBox_type_things.Text;
                CountOfProducts.Text = CountOfProducts.Minimum.ToString();
            }
        }
        

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program include list of products and things bought by family Zolotarenko\n" +
                            @"author: M.Zolotarenko", @"Information");
        }

        /// <summary>
        /// Method for reset all products from listView (not database)
        /// </summary>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            listView_Item.Items.Clear();
            textBox_TotalPrice.Text = @"0";
            price = 0;
        }

        /// <summary>
        /// Method for save items in listView to database
        /// </summary>
        private void button_Save_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            textBox_TotalPrice.Text = price.ToString(CultureInfo.InvariantCulture);
            foreach (ListViewItem item in listView_Item.Items)
            {
                p.Name = item.SubItems[1].Text;
                p.Price = Convert.ToDouble(item.SubItems[2].Text);
                p.Count = Convert.ToInt32(item.SubItems[3].Text);
                p.TotalPrice = Convert.ToDouble(item.SubItems[4].Text);
                p.Type = item.SubItems[5].Text;
                p.Date = Convert.ToDateTime(item.SubItems[6].Text);
                op.Insert(p);
            }
            MessageBox.Show(@"Saved successfully", @"Info");
        }

        /// <summary>
        /// Method for select our products from database
        /// </summary>
        private void button_Select_Click(object sender, EventArgs e)
        {
            price = 0;
            date = dateTimePicker_Select.Value.Date;
            type = comboBox_Select_Type.Text;
            listView_select.Items.Clear();
            day = checkBox_day.Checked;
            mounth = checkBox_Mounth.Checked;
            var listik = op.Select(ref day, ref mounth, ref date, ref type);
            foreach (var a in listik)
            {
                var list = new ListViewItem(a.Id.ToString());
                list.SubItems.Add(a.Name.ToString());
                list.SubItems.Add(String.Format(new System.Globalization.CultureInfo("uk-UA"), "{0:F}", a.Price));
                list.SubItems.Add(a.Count.ToString());
                list.SubItems.Add(String.Format(new System.Globalization.CultureInfo("uk-UA"), "{0:F}", a.TotalPrice));
                list.SubItems.Add(a.Type.ToString());
                list.SubItems.Add(Convert.ToDateTime(a.Date).ToString("D"));
                listView_select.Items.Add(list);
                price += Convert.ToDouble(a.TotalPrice.ToString());
            }
            //show total price
            Total_Price_Select.Text = price.ToString("F");  
        }

        /// <summary>
        /// Method for clear all products from database!!!
        /// </summary>
        private void button_clear_table_Click(object sender, EventArgs e)
        {
            op.Clear_table();
            MessageBox.Show(@"Table was cleaned!", @"Info");
            button_Select_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// reset listView (not database)
        /// </summary>
        private void button_Reset_Select_Click(object sender, EventArgs e)
        {
            listView_select.Items.Clear();
            Total_Price_Select.Text = @"0";
            price = 0;
        }

        /// <summary>
        /// Method for remove selected product from listView (not database) 
        /// </summary>
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listView_Item.SelectedItems.Count == 0) return;
            price -= Convert.ToDouble(listView_Item.SelectedItems[0].SubItems[4].Text);
            listView_Item.SelectedItems[0].Remove();
            textBox_TotalPrice.Text = price.ToString(CultureInfo.InvariantCulture);
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            button_Save_Click(sender, e);
        }

        /// <summary>
        /// Method for remove selected product from database 
        /// </summary>
        private void button_remove_from_db_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            if (listView_select.SelectedItems.Count == 0) return;
            p.Id = listView_select.SelectedItems[0].Text.Substring(0, 36);
            op.Delete(p);
            MessageBox.Show(@"Rows was deleted!", @"Info");
            button_Select_Click(this, EventArgs.Empty);
        }
        
    }
}
