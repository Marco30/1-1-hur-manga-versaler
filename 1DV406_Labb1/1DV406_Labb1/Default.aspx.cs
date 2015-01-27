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

        protected void Knap_Click(object sender, EventArgs e)
        {
            

            if (Knap.Text == "Rensa")
            {
                TextBox1.Enabled = true;

                TextBox1.Text = "";

                TextBox1.Enabled = true;

                Resultat.Visible = false;

                Knap.Text = "Antal versaler";
            }
            else if (Knap.Text == "Antal versaler")
            {
                int stor = Model.TextAnalyzer.Versaler(TextBox1.Text);

                TextBox1.Enabled = false;

                Resultat.Text = String.Format("Texten har {0} versaler", stor);

                Resultat.Visible = true;

                Knap.Text = "Rensa";
            }
     
        }

       

    }
}