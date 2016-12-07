using System;
using DAL;

namespace TUDAI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var noticBuss = new NoticiaBusiness();
            gvNoticias.DataSource = noticBuss.GetNoticias();
            gvNoticias.DataBind();
        }
    }
}