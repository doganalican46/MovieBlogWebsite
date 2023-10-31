using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var query = from x in db.Admins where x.USERNAME == TextBox1.Text && x.PASSWORD == TextBox2.Text select x;
            if (query.Any())
            {
                Session.Add("USERNAME", TextBox1.Text);
                Response.Redirect("/AdminPages/Blogs.Aspx");
            }
            else
            {
                Response.Write("Error!");
            }
        }
    }
}