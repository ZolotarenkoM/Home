using System;

namespace Domain
{
    /// <summary>
    /// Class describes product properties
    /// </summary>
    public class Product
    {
        string id;
        string name;
        double price;
        int count;
        double total_price;
        string type;
        DateTime date;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public double TotalPrice
        {
            get { return total_price; }
            set { total_price = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }    
    }
}
