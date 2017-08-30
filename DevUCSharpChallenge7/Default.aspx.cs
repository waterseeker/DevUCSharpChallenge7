using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpChallenge7
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            string[] names = new string[] {"Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolverine",
            "Nightcrawler", "Storm", "Colossus"};

            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            resultLabel.Text = result;
        }
    }
}