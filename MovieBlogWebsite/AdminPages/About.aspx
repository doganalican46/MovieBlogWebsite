<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MovieBlogWebsite.AdminPages.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <h3>About Description:</h3>
        <br />
        <asp:TextBox ID="AboutDescription" runat="server" placeholder="About Description" CssClass="form-control" TextMode="MultiLine" Height="300" required=""></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="SAVE" CssClass="btn btn-primary" OnClick="Button1_Click" />
    </form>

</asp:Content>
