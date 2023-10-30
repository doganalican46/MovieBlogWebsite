using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite
{
    public partial class BlogDetails : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Where(x=>x.BLOGID==id).ToList();
            Repeater1.DataSource=blog;
            Repeater1.DataBind();


            var comments = db.TBLCOMMENT.Where(y => y.COMMENTBLOG == id).ToList();
            Repeater2.DataSource = comments;
            Repeater2.DataBind();
        }
    }
}