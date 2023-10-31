using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;

namespace MovieBlogWebsite.AdminPages
{
    public partial class DeleteBlog : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(x);
            db.TBLBLOG.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Blogs.Aspx");
        }
    }
}