<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateComment.aspx.cs" Inherits="MovieBlogWebsite.AdminPages.UpdateComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Tittle" CssClass="form-control"  Enabled="false" ></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Username" CssClass="form-control" ></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" placeholder="Comment content" CssClass="form-control" TextMode="MultiLine" Height="300" required=""></asp:TextBox>
        <br />

        <asp:Button ID="Button1" runat="server" Text="UPDATE" CssClass="btn btn-primary" OnClick="Button1_Click"   />
    </form>

</asp:Content>
