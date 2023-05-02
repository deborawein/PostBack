using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class TestCheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CheckBoxControl checkBoxControl = (CheckBoxControl)this.LoadControl("~/CheckBoxControl.ascx");
            checkBoxControl.ID = "checkBoxControl";
            PhAnswers2.Controls.Add(checkBoxControl);


        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            CheckBoxControl cblControlTmp = (CheckBoxControl)this.FindControl("checkBoxControl");
            foreach( String item in  cblControlTmp.SelectedItem )
            {
                Response.Write(item);
            }
            

        }
    }
}
