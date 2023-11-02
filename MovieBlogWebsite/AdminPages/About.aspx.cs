using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite.AdminPages
{
    public partial class About : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["USERNAME"] == null)
            {
                Response.Redirect("~/LoginPage.Aspx");
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}