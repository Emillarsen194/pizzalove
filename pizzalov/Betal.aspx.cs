using PizzaLove;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using pizzalov;

namespace pizzalov
{
    public partial class Betal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                PizzaManager manager = new PizzaManager();

                GridView1.DataSource = manager.DisplayAddedPizza();
                GridView1.DataBind();



            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }




        protected void Opretb_Click(object sender, EventArgs e)
        {
            string fornavn = Fornavn.Text;
            string efternavn = Efternavn.Text; //creating a empty string were gonna print with our label later
            string tlfnr = Tlfnr.Text;
            string adresse = Adresse.Text;
            string postnr = Postnr.Text;

            PizzaManager manager = new PizzaManager();

            string addedUser = manager.AddUser(fornavn, efternavn, tlfnr, adresse, postnr);

            Label1.Text = addedUser;

         



        }

        protected void Betalb_Click(object sender, EventArgs e) 
        {

            betalt.Text = "Tak for din bestilling din pizza/pizzaer er klar om 10-15 minutter";

        }

        protected void Kid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}