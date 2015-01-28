using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1DV406_Labb1//Marco Villegas
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Knap_Click(object sender, EventArgs e)// funktionen som startar när kanpen trycks 
        {


            if (Knap.Text == "Rensa")// Nolställer text rutan om knapens text är rensa
            {
                TextBox1.Enabled = true;// man kan skriva i rutan igen 

                TextBox1.Text = "";// rensar text rutan 

                Resultat.Visible = false;// tar bort resultat testen 

                Knap.Text = "Antal versaler";// knapen får texten Antal versaler
            }
            else if (Knap.Text == "Antal versaler")// Startar funktionen som räknar versaler n om knapens text är Antal versaler
            {
                int stor = Model.TextAnalyzer.Versaler(TextBox1.Text);// anropar funktion som räknar versaler

                TextBox1.Enabled = false;// man kan inte längre skriva i text rutan 

                Resultat.Text = String.Format("Texten har {0} versaler", stor);// visar text med resultat

                Resultat.Visible = true;// gör så att resultat texten visas på sidan 

                Knap.Text = "Rensa";// knapen får texten rensa 
            }
     
        }

       

    }
}