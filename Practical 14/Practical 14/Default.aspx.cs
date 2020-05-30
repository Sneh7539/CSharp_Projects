using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_14
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label3.Text = Request.QueryString["Usrnm"];
            Label4.Text = Request.QueryString["Pwd"];
        }
    }
}