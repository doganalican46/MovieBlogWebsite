using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLCONTACT contact = new TBLCONTACT();
            contact.NAMESURNAME = TextBox1.Text;
            contact.MAIL = TextBox2.Text;
            contact.SUBJ = TextBox6.Text;
            contact.PHONE = TextBox3.Text;
            contact.MESAGE = TextBox5.Text;
            db.TBLCONTACT.Add(contact);
            db.SaveChanges();
        }
    }
}