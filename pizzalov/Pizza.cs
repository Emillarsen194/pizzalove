using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PizzaLove
{
    public class Pizza
    {
        

        private int pizzaid;
        private int price;
        private string name;
        private string size;
        private string content;


        #region makeitpublic
        public int Pizzaid
        {
            get
            {
                return pizzaid;
            }
            set
            {
                pizzaid = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        #endregion

        public Pizza(int pid, int pr, string na, string siz, string con)
        {
            this.pizzaid = pid;
            this.price = pr;
            this.name = na;
            this.size = siz;
            this.content = con;


        }

        public Pizza(int pid, int pr)
        {
            this.pizzaid = pid;
            this.price = pr;
        }

    }
}
