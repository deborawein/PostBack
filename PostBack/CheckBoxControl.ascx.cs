using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class CheckBoxControl : System.Web.UI.UserControl
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

                    CblAnswer.Items.Add(listItem);

                }
            }
        }
        public List<String> SelectedItem
        {
            get
            {
                List<String> selectedList = new List<String>();


                foreach (ListItem item in CblAnswer.Items)
                {
                    if (item.Selected)
                    {
                        selectedList.Add(item.Text);
                    }
                }
                return selectedList;
            }
        }
    }
}