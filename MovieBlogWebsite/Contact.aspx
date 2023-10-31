﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MovieBlogWebsite.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <body>

        <div class="contact-content">
            <div class="container">
                <div class="contact-info">
                    <h2>CONTACT</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Contrary to popular belief.</p>
                </div>
                <div class="contact-details">
                    <form runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Name" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Email" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox6" runat="server" placeholder="Subject" required=""></asp:TextBox>

                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Phone" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="Message" required="" TextMode="MultiLine" Height="100"></asp:TextBox>

                        <asp:Button ID="Button1" runat="server" Text="SEND" OnClick="Button1_Click" />
                    </form>
                </div>
                <div class="contact-details">
                    <div class="col-md-6 contact-map">
                        <h4>FIND US HERE</h4>
                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d803187.8113675824!2d-120.11910914056458!3d38.15292455846902!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x808fb9fe5f285e3d%3A0x8b5109a227086f55!2sCalifornia%2C+USA!5e0!3m2!1sen!2sin!4v1423829283333" frameborder="0" style="border: 0"></iframe>
                    </div>
                    <div class="col-md-6 company_address">
                        <h4>GET IN TOUCH</h4>
                        <p>500 Lorem Ipsum Dolor Sit,</p>
                        <p>22-56-2-9 Sit Amet, Lorem,</p>
                        <p>USA</p>
                        <p>Phone:(00) 222 666 444</p>
                        <p>Fax: (000) 123 456 78 0</p>
                        <p>Email: <a href="mailto:info@example.com">info@mycompany.com</a></p>
                        <p>Follow on: <a href="#">Facebook</a>, <a href="#">Twitter</a></p>
                    </div>
                    <div class="clearfix"></div>
                </div>


            </div>
        </div>
        <!---->
</asp:Content>
