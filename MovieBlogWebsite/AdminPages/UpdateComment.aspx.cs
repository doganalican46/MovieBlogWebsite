using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite.AdminPages
{
    public partial class UpdateComment : System.Web.UI.Page
    {

        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] == null)
            {
                Response.Redirect("~/LoginPage.Aspx");
            }
            int y = int.Parse(Request.QueryString["COMMENTID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLCOMMENT.Find(y);
                TextBox1.Text = deger.TBLBLOG.BLOGTITTLE;
                TextBox2.Text = deger.USERNAME;
                TextBox4.Text = deger.COMMENT;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["COMMENTID"]);
            var comment = db.TBLCOMMENT.Find(y);
            comment.USERNAME = TextBox1.Text;
            comment.COMMENT = TextBox4.Text;            
           
            db.SaveChanges();
            Response.Redirect("Comments.Aspx");
        }
    }
}