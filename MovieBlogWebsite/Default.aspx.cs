﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite
{
    public partial class Default2 : System.Web.UI.Page
    {
        BlogMovieEntities db = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var blogs = db.TBLBLOG.ToList();
            Repeater1.DataSource = blogs;
            Repeater1.DataBind();

            var category = db.TBLCATEGORY.ToList();
            Repeater2.DataSource = category;
            Repeater2.DataBind();

            var blogs2 = db.TBLBLOG.Take(5).ToList();
            Repeater3.DataSource = blogs2;
            Repeater3.DataBind();


            var blogs3 = db.TBLCOMMENT.Take(3).ToList();
            Repeater4.DataSource = blogs3;
            Repeater4.DataBind();
        }
    }
}