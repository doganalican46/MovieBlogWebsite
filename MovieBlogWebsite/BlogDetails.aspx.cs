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

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BLOGID"]);
            TBLCOMMENT comment = new TBLCOMMENT();
            comment.USERNAME = TextBox1.Text;
            comment.MAIL = TextBox2.Text;
            comment.COMMENT = TextBox3.Text;
            comment.COMMENTBLOG = id;
            db.TBLCOMMENT.Add(comment);
            db.SaveChanges();
            Response.Redirect("BlogDetails.Aspx?BLOGID=" + id);
        }
    }
}