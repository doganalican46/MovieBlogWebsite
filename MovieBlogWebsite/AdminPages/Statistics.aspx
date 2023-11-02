<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="MovieBlogWebsite.AdminPages.Statistics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>STATISTICS:</h3>
    <br />
    <br />
    <table class="table table-bordered table-hover">
        <tbody>
            <tr>
                <td>Total Blogs:
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Total Comments:
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Total Movies:
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Total Series:
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Total Animations:
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Total Documentary:
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Most Popular Blog:
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>

            </tr>
        </tbody>
    </table>

</asp:Content>
