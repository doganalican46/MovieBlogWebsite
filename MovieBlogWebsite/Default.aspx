﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MovieBlogWebsite.Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="content-grids">


            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <img src="web/images/post1.jpg" alt="" />
                                <div class="post-info">
                                    <h4><a href="BlogDetails.Aspx?BLOGID=<%# Eval("BLOGID")  %>"><%# Eval("BLOGTITTLE")  %> </a><%# Eval("BLOGDATE")  %></h4>
                                    <p><%# Eval("BLOGCONTENT")  %></p>
                                    <a href="BlogDetails.Aspx?BLOGID=<%# Eval("BLOGID")  %>"><span></span>READ MORE</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>


            <div class="col-md-4 content-right">
                <div class="recent">
                    <h3>RECENT POSTS</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li><a href="BlogDetails.Aspx?BLOGID=<%# Eval("BLOGID")  %>"><%# Eval("BLOGTITTLE")  %> </a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="comments">
                    <h3>RECENT COMMENTS</h3>

                    <asp:Repeater ID="Repeater4" runat="server">
                        <ItemTemplate>
                            <ul>
                                <li><a href="#"> <%# Eval("USERNAME")  %>: <%# Eval("COMMENT")  %></a>
                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
                <div class="clearfix"></div>
                
                <div class="categories">
                    <h3>CATEGORIES</h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="CategoryDetails.Aspx?CATEGORYID=<%# Eval("CATEGORYID")  %>"><%# Eval("TYPENAME")  %> </a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>


            <div class="clearfix"></div>
        </div>
    </div>

</asp:Content>
