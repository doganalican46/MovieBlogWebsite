<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateBlog.aspx.cs" Inherits="MovieBlogWebsite.AdminPages.UpdateBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Tittle" CssClass="form-control" required=""></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Date" CssClass="form-control" required=""></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" placeholder="Image" CssClass="form-control" required=""></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataTextField="TYPENAME" DataValueField="TYPEID" required=""></asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataTextField="TYPENAME" DataValueField="CATEGORYID" required=""></asp:DropDownList>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" placeholder="About Blog" CssClass="form-control" TextMode="MultiLine" Height="300" required=""></asp:TextBox>
        <br />

        <asp:Button ID="Button1" runat="server" Text="UPDATE" CssClass="btn btn-primary" OnClick="Button1_Click"  />
    </form>

</asp:Content>
