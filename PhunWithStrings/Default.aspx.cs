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

        protected void challenge2Button_Click(object sender, EventArgs e)
        {
            var splitSequence = GetSequenceArray("Luke,Leia,Han,Chewbacca");
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = splitSequence.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    stringBuilder.Append(splitSequence[i]);
                else
                    stringBuilder.Append($"{splitSequence[i]}, ");
            }

            challenge2ResultLabel.Text = stringBuilder.ToString();
        }

        private string[] GetSequenceArray(string sequence)
        {
            return sequence.Split(',');
        }

        protected void challenge3Button_Click(object sender, EventArgs e)
        {
            var splitSequence = GetSequenceArray("Luke,Leia,Han,Chewbacca");
            StringBuilder stringBuilder = new StringBuilder();
            string newString = "";

            for (int i = splitSequence.Length - 1; i >= 0; i--)
            {
                var padding = (14 - splitSequence[i].Length) / 2;
                stringBuilder.Append($"{splitSequence[i].PadLeft(splitSequence[i].Length + padding, '*').PadRight(14,'*')}<br/>");
            }

            challenge3ResultLabel.Text = stringBuilder.ToString();
        }
    }
}