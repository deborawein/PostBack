using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    
    public partial class TestMultiControl : System.Web.UI.Page
    {
        public String control;
        protected void Page_Load(object sender, EventArgs e)
        {

                RadioButtonControl radioButtonControl = (RadioButtonControl)this.LoadControl("~/RadioButtonControl.ascx");
                radioButtonControl.ID = "radioButtonControl";
                PhAnswers3.Controls.Add(radioButtonControl);
                control = "radio";
            
        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            

            if(control == "radioodebi")
            {
                RadioButtonControl rblControlTmp = (RadioButtonControl)this.FindControl("radioButtonControl");
                Response.Write("Radio: <br />" + rblControlTmp.SelectedItem);

                CheckBoxControl checkBoxControl = (CheckBoxControl)this.LoadControl("~/CheckBoxControl.ascx");
                checkBoxControl.ID = "checkBoxControl";
                PhAnswers3.Controls.Add(checkBoxControl);
                control = "checkbox";
            }
            else
            {
                CheckBoxControl cblControlTmp = (CheckBoxControl)this.FindControl("checkBoxControl");
                foreach (String item in cblControlTmp.SelectedItem)
                {
                    Response.Write("CheckBox: <br />" + item);
                }
            }

        






    }
    }
}