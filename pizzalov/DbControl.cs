using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections.ObjectModel;

namespace PizzaLove
{
    public class DbControl
    {
        //private string dbConString = @"Data Source=192.168.1.55;Initial Catalog=pizzalove;User ID=sa;Password=Mike1234M";
        //private string dbLocalConString = @"Data Source=ZBC-MADS648I\MYSQL;Initial Catalog=pizzalove;Integrated Security=true";
        private String dbConString = @"Data Source=ZBC-PAAEMIL8398;Initial Catalog=pizzalove;Integrated Security=True";


        public string DbConString
        {
            get
            {
                return dbConString;
            }
        }



        public DbControl()
        {

        }



        public List<Pizza> GetPizza(string searchCriteria) // get pizza is where we search for a pizza in our viewgrid
        {
            List<Pizza> pizzas = new List<Pizza>(); //makes a list of pizzas
            SqlConnection sqlCon = new SqlConnection(DbConString); //makes the connection from our connection string

            sqlCon.Open(); // opens the connection

            string query = "select * from Pizza where Indhold like '%" + searchCriteria + "%'"; // our search query
            SqlCommand com = new SqlCommand(query, sqlCon); //making a sql command that uses  our query and connection 

            SqlDataReader dr = com.ExecuteReader(); //data reader that execeutes our reader

            if (dr.HasRows) //if there any rows in our table 
            {
                while (dr.Read()) // while datareader reads
                {
                    //add a new pizza as a object
                    pizzas.Add(new Pizza(Convert.ToInt32(dr["Pizzaid"]), Convert.ToInt32(dr["Pris"]), dr["Navn"].ToString(), dr["Størrelse"].ToString(), dr["Indhold"].ToString()));
                }
            }

            return pizzas; //returns our list to pizza manager

        }

        public List<Pizza> SelectPizza(string id, string price) //the method where we can select pizzas 
        {

            List<Pizza> selectedPizzas = new List<Pizza>();

            SqlConnection sqlCon = new SqlConnection(DbConString);



            sqlCon.Open(); //opens our connection 


            String query = @"INSERT INTO Tmpbestil (Pizzaid,Totalsum) Values('" + id + "','" + price + "')"; //query string that insert the selected pizza to our tmpbestil table
            SqlCommand com = new SqlCommand(query, sqlCon);
            com.ExecuteNonQuery(); // exceutes our query 

            selectedPizzas.Add(new Pizza(Convert.ToInt32(id), Convert.ToInt32(price))); //adds the pizza to the list

            return selectedPizzas; //return selected pizzas list 
        }






        public List<Pizza> DisplayAllPizza() // display all pizzas in our view grid
        {
            List<Pizza> pizzas = new List<Pizza>();
            SqlConnection sqlCon = new SqlConnection(DbConString);

            sqlCon.Open(); //open the connection 

            string query = "select * from Pizza"; //takes all from our pizza list 
            SqlCommand com = new SqlCommand(query, sqlCon);

            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows) // if theres any rows in our pizzatable
            {
                while (dr.Read())
                {
                    pizzas.Add(new Pizza(Convert.ToInt32(dr["Pizzaid"]), Convert.ToInt32(dr["Pris"]), dr["Navn"].ToString(), dr["Størrelse"].ToString(), dr["Indhold"].ToString()));
                }
            }

            return pizzas; //return our pizzas list 


        }

        public List<Pizza> DisplaySelectedPizzas() //method that display our selected pizzas in viewgrid 3
        {
            List<Pizza> selectedPizzas = new List<Pizza>(); //making a new list of selected pizzas 
            SqlConnection sqlCon = new SqlConnection(DbConString);

            sqlCon.Open(); // opens the connection 

            string query = "select * from Tmpbestil"; //selecting all from tmp bestil 
            SqlCommand com = new SqlCommand(query, sqlCon);

            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows) //if datareader has rows 
            {

                while (dr.Read())
                {
                    selectedPizzas.Add(new Pizza(Convert.ToInt32(dr["Pizzaid"]), Convert.ToInt32(dr["Totalsum"])));
                }
            }


            return selectedPizzas; //return list 


        }





        public void EmptyTemp() //emptys tmp bestil everytime user reloads the menu site
        {

            SqlConnection sqlCon = new SqlConnection(DbConString);
            sqlCon.Open();
            String query = @"
            delete from Tmpbestil
            WHERE Pizzaid < 50";
            SqlCommand com = new SqlCommand(query, sqlCon);
            com.ExecuteNonQuery();
        }


        public string AddUser(string fornavn, string efternavn, string tlfnr, string adresse, string postnr) // add a new costumer
        {

            string created = string.Empty; //to check if user is created and give user his kId 

            SqlConnection sqlCon = new SqlConnection(DbConString);


            sqlCon.Open();


            //Summary 
            //creates a coustumer
            String query = @"INSERT INTO Kunde (Fornavn,Efternavn,Telefon_nr,Adresse,Postnr) Values('" + fornavn + "','" + efternavn + "','" + tlfnr + "','" + adresse + "','" + postnr + "')";
            String getkid = @"SELECT Kid FROM Kunde
                              WHERE Telefon_nr = " + tlfnr; //takes the kid from telefonnr
            SqlCommand com = new SqlCommand(query, sqlCon);
            com.ExecuteNonQuery();

            SqlDataReader Reader = null; //making reader
            SqlCommand cmd = new SqlCommand(getkid, sqlCon); //get kid query runs 
            Reader = cmd.ExecuteReader();

            while (Reader.Read()) //finds kid in the same row as tlf number
            {

                created = "Oprettede: " + fornavn.ToString() + " Kunde id: " + Reader["Kid"].ToString();

            }


            return created; //return string created
        }



         
        public void RemoveSelectedPizza(string id) //removes a pizza from tmp bestil list 
        {

            SqlConnection sqlCon = new SqlConnection(DbConString);



            sqlCon.Open();


            String query = @"DELETE FROM Tmpbestil WHERE Pizzaid = " + "'" + id + "'"; //deletes from tmpbestil where pizzaid is selected row
            SqlCommand com = new SqlCommand(query, sqlCon);
            com.ExecuteNonQuery();
        }

           

            





    }

}
