using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Fools_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoolsDetails.html");
        }
        protected void Zoombie_Click(object sender, EventArgs e)
        {
            Response.Redirect("zoombie.html");
        }
    }
}