using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite.AdminPages
{
    public partial class DeleteComment : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["COMMENTID"]);
            var comment = db.TBLCOMMENT.Find(x);
            db.TBLCOMMENT.Remove(comment);
            db.SaveChanges();
            Response.Redirect("Comments.Aspx");
        }
    }
}