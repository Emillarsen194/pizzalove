using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaLove;
namespace pizzalov
{
    public class PizzaManager
    {
        // Looks for pizzas that matches the searchCriteria and then returns it back to the user
        public List<Pizza> GetPizza(string searchCriteria)
        {
            
            DbControl dal = new DbControl(); 

            return dal.GetPizza(searchCriteria);

        }

        // when the user selects a pizza it is then thrown into a temp table
        // then also adds the pizza to a list and then returns that list
        public List<Pizza> SelectPizza(string id, string price)
        {
            DbControl dal = new DbControl();

            return dal.SelectPizza(id, price);
        }

        // gets all the pizzas from the database then returns a list of all the pizzas to display
        public List<Pizza> DisplayPizza()
        {
            DbControl dal = new DbControl();

            return dal.DisplayAllPizza();
        }

        // empties the temp table
        public void EmptyTemp()
        {
            DbControl control = new DbControl();
            control.EmptyTemp();
        }

        // When the user has selected a pizza or pizzas this method then get the list of pizzas from the temp table
        // and then returns the list of pizzas to be displayed
        public List<Pizza> DisplayAddedPizza()
        {
            DbControl dal = new DbControl();

            return dal.DisplaySelectedPizzas();

        }

        // creates a user from the user input on payment part of the website
        // that then returns a string to let the user know it worked
        public string AddUser(string fornavn, string efternavn, string tlfnr, string adresse, string postnr)
        {
            DbControl dal = new DbControl();

            return dal.AddUser(fornavn, efternavn, tlfnr, adresse, postnr); 
        }
           
        // this method let the user remove a pizza from the orderlist
        public void RemoveFromOrder(string id)
        {
            DbControl dal = new DbControl();

            dal.RemoveSelectedPizza(id);
        }

    }


}