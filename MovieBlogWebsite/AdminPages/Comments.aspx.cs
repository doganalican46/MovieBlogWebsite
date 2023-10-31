using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite.AdminPages
{
    public partial class Comments : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var comments = (from x in db.TBLCOMMENT
                            select new
                            {
                                x.COMMENTID,
                                x.USERNAME,
                                x.TBLBLOG.BLOGTITTLE
                            }).ToList();

            Repeater1.DataSource = comments;
            Repeater1.DataBind();
        }
    }
}