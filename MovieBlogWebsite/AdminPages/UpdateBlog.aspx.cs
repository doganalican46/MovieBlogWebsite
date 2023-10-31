using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite.AdminPages
{
    public partial class UpdateBlog : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            if (Page.IsPostBack == false)
            {
                var types = (from x in db.TBLTYPE
                             select new
                             {
                                 x.TYPENAME,
                                 x.TYPEID
                             }).ToList();
                DropDownList1.DataSource = types;
                DropDownList1.DataBind();

                var category = (from x in db.TBLCATEGORY
                                select new
                                {
                                    x.TYPENAME,
                                    x.CATEGORYID
                                }).ToList();
                DropDownList2.DataSource = category;
                DropDownList2.DataBind();
                var deger = db.TBLBLOG.Find(y);
                TextBox1.Text = deger.BLOGTITTLE;
                TextBox2.Text = deger.BLOGDATE.ToString();
                TextBox3.Text = deger.BLOGIMAGE;
                TextBox4.Text = deger.BLOGCONTENT;
                DropDownList1.SelectedValue = deger.BLOGTYPE.ToString();
                DropDownList2.SelectedValue = deger.BLOGCATEGORY.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(y);
            blog.BLOGTITTLE = TextBox1.Text;
            blog.BLOGDATE = DateTime.Parse(TextBox2.Text);
            blog.BLOGIMAGE = TextBox3.Text;
            blog.BLOGCONTENT = TextBox4.Text;
            blog.BLOGTYPE = byte.Parse(DropDownList1.SelectedValue);
            blog.BLOGCATEGORY = byte.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Blogs.Aspx");

        }
    }
}