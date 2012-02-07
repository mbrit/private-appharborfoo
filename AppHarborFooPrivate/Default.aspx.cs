using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppHarborFooPrivate
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // foo
        }

        public string Message
        {
            get
            {
                return "Welcome to this private AppHarbor repo - " + DateTime.UtcNow.ToString();
            }
        }
    }
}