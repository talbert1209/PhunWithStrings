using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void challenge1Button_Click(object sender, EventArgs e)
        {
            var inputText = TextBox1.Text.Trim();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(inputText[i]);
            }

            challenge1ResultLabel.Text = stringBuilder.ToString();
        }
    }
}