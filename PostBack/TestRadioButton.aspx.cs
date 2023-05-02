using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class TestRadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                RadioButtonControl radioButtonControl = (RadioButtonControl)this.LoadControl("~/RadioButtonControl.ascx");
                radioButtonControl.ID = "radioButtonControl";
                PhAnswers.Controls.Add(radioButtonControl);


        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            RadioButtonControl rblControlTmp = (RadioButtonControl)this.FindControl("radioButtonControl");
            Response.Write("Selected answer: <br />" + rblControlTmp.SelectedItem);
          
        }
    }
}