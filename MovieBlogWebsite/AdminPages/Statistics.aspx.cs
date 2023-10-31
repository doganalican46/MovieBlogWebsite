using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite.AdminPages
{
    public partial class Statistics : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLBLOG.Count().ToString();
            Label2.Text = db.TBLBLOG.Where(x => x.BLOGTYPE == 1).Count().ToString();
            Label3.Text = db.TBLBLOG.Where(x => x.BLOGTYPE == 2).Count().ToString();
            Label4.Text = db.TBLCOMMENT.Count().ToString();
            Label5.Text = db.TBLBLOG.Where(x => x.BLOGTYPE == 4).Count().ToString();
            Label6.Text = db.TBLBLOG.Where(x => x.BLOGTYPE == 3).Count().ToString();
            Label7.Text = db.TBLBLOG.Where(y => y.BLOGID == (db.TBLCOMMENT.GroupBy(x => x.COMMENTBLOG).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k => k.BLOGTITTLE).FirstOrDefault();

        }
    }
}