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

            //loop through both arrays to display the X-man with the most battles and the 
            //one with the fewest like this....
            //Most battles belongs to: Phoenix (Value: 17)
            //Least battles belongs to: Wolverine (Value: 2)

            //need to store the # and index of # for highest and lowest
            //then use the indexes to get the names from the other array
            //and write to the resultLabel

            int highest;
            int lowest;
            for (int i = 0; i < length; i++)
            {
                if names[i] == "Phoenix" 
            }

            resultLabel.Text = result;
        }
    }
}