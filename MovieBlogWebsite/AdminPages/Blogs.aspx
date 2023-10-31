<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Blogs.aspx.cs" Inherits="MovieBlogWebsite.AdminPages.Blogs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-hover">
        <thead>
            <tr>
                <td>ID</td>
                <td>TITTLE</td>
                <td>DATE</td>
                <td>TYPE</td>
                <td>CATEGORY</td>
                <td>PROCESS</td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("BLOGID") %> </td>
                        <td><%# Eval("BLOGTITTLE") %> </td>
                        <td><%# Eval("BLOGDATE") %> </td>
                        <td><%# Eval("BLOGTYPE") %> </td>
                        <td><%# Eval("BLOGCATEGORY") %> </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "DeleteBlog.Aspx?BLOGID=" + Eval("BLOGID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "UpdateBlog.Aspx?BLOGID=" + Eval("BLOGID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Update</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>

    <a href="NewBlog.Aspx" class="btn btn-primary">New Blog</a>

</asp:Content>
