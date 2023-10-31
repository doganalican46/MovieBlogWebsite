using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite
{
    public partial class CategoryDetails : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["CATEGORYID"]);
            var blogs = db.TBLBLOG.Where(x => x.BLOGCATEGORY == id).ToList();
            Repeater1.DataSource = blogs;
            Repeater1.DataBind();

            var category = db.TBLCATEGORY.ToList();
            Repeater2.DataSource = category;
            Repeater2.DataBind();

            var blogs2 = db.TBLBLOG.ToList();
            Repeater3.DataSource = blogs2;
            Repeater3.DataBind();
        }
    }
}