using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ResultLabel.Text = "";
    }

    protected void OkBtn_Click(object sender, EventArgs e)
    {
        // ResultLabel.Text = "<p style=\"color: #ff33ff;\">Hi</p>";

        string value = ValueTextBox.Text; ;

        // Access specific character
        // ResultLabel.Text = value[2].ToString();

        // StartWith(), EndsWith(), Contains()
        // if (value.StartsWith("a"))
        //     ResultLabel.Text = "It starts with 'a'";
        // if (value.EndsWith("."))
        //     ResultLabel.Text += "It ends with a '.'";
        // if (value.Contains("good"))
        //     ResultLabel.Text += "contains the word 'good'";

        // IndexOf()
        int index = value.IndexOf("good");
        // ResultLabel.Text = "'good' begins at index " + index.ToString();

        // Insert, Remove
        // ResultLabel.Text = value.Insert(index, "jolly ");

        // ResultLabel.Text = value.Remove(index, value.Length - index);

        // Substring
        // ResultLabel.Text = value.Substring(index, value.Length - index - 1);

        // Trim() -- trims off whitespace before and after the string
        // ResultLabel.Text = String.Format("Length before: {0}<br />Length after: {1}", value.Length, value.Trim().Length);

        // PadLeft(), PadRight() -- forces the length of the string by adding chars
        // ResultLabel.Text = value.PadLeft(10, '*');

        // if (ValueTextBox.Text.Trim().ToUpper() == "BOB") ResultLabel.Text = "same strings";
        // else ResultLabel.Text = "They are not the same";

        // Replace()
        // string template = "[NAME] wants to see you. Go see [NAME]";
        // ResultLabel.Text = template.Replace("[NAME]", ValueTextBox.Text);

        // Split()
        //string result = "";
        //string[] values = ValueTextBox.Text.Split(',');
        //for (var i = 0; i < values.Length; i++)
        //{
        //    result += values[i] + " " + values[i].Length + "<br />";
        //}

        //ResultLabel.Text = result;

        // Can also use a string builder which is better on memory. It requires the System.Text namespace
        StringBuilder sb = new StringBuilder();
        string[] values = ValueTextBox.Text.Split(',');

        for (var i = 0; i < values.Length; i++)
        {
            sb.Append(values[i]);
            sb.Append(" ");
            sb.Append(values[i].Length);
            sb.Append("<br />");
        }
        ResultLabel.Text = sb.ToString();

        
    }
}