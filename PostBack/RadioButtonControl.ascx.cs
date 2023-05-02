using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class RadioButtonControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i < 5; i++)
                {
                    ListItem listItem = new ListItem();
                    listItem.Text = "Option" + i;
                    listItem.Value = "" + i;

                    RblAnswer.Items.Add(listItem);

                }
            }

        }

        public String SelectedItem
        {
            get
            {
                return RblAnswer.SelectedItem.Text;
            }
        }

    }
}