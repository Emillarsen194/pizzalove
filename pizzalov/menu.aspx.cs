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

namespace pizzalov
{


    public partial class menu : System.Web.UI.Page
    {
        public bool test = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            PizzaManager manager = new PizzaManager();

            if (!this.IsPostBack) // if its not getting loaded for the first time
            {
                
              
                manager.EmptyTemp();//It removes from the temptable

                GridView1.DataSource = manager.DisplayPizza();//Displays data in gridview1
                GridView1.DataBind();

            
            }

            else if (this.IsPostBack)
            {
                

            }
        }


        public void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            PizzaManager manager = new PizzaManager();//Here we create a new object called manager

            string pizzaid = GridView1.SelectedRow.Cells[1].Text; //creating a empty string were gonna print with our label later
            string pris = GridView1.SelectedRow.Cells[2].Text;

            List<Pizza> selectedPizza = manager.SelectPizza(pizzaid, pris);//Making a new list that contains pizzaid and price

            GridView3.DataSource = manager.DisplayAddedPizza();//Displaying data in gridview3
            GridView3.DataBind();//Binds data







        }



        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



      

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
      
      {

        }

       

        protected void GridView3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string pizzaid = GridView3.SelectedRow.Cells[1].Text;

            PizzaManager manager = new PizzaManager();//Here we create a new object called manager

            manager.RemoveFromOrder(pizzaid);

            GridView3.DataSource = manager.DisplayAddedPizza();//Here we display data to gridview3
            GridView3.DataBind();

        }

    

   
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            PizzaManager manager = new PizzaManager();//Here we create a new object called manager

            List<Pizza> pizzas = manager.GetPizza(TextBox1.Text);

            GridView1.DataSource = pizzas;

            GridView1.DataBind();

           

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)//It directs us to "betal" page
        {
            Response.Redirect("Betal.aspx");
        }
    }
}


