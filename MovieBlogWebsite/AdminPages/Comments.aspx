<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="MovieBlogWebsite.AdminPages.Comments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-hover">
        <thead>
            <tr>
                <td>ID</td>
                <td>USERNAME</td>
                <td>BLOG</td>
                <td>PROCESS</td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("COMMENTID") %> </td>
                        <td><%# Eval("USERNAME") %> </td>
                        <td><%# Eval("BLOGTITTLE") %> </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "DeleteComment.Aspx?COMMENTID=" + Eval("COMMENTID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "UpdateComment.Aspx?COMMENTID=" + Eval("COMMENTID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Update</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>

    <a href="NewBlog.Aspx" class="btn btn-primary">New Blog</a>


</asp:Content>
