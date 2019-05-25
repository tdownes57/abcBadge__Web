<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="~/Views/PortraitImage/Index.cs" Inherits="ciBadgeForWeb.Views.PortraitImage.Index1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">  
            Index  
</asp:Content>  

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">  

   <a href="https://www.c-sharpcorner.com/uploadfile/dhananjaycoder/working-with-images-in-Asp-Net-mvc-framework/">Working with Images in ASP.Net MVC Framework   </a>

   <% foreach (var each_portrait_image in ViewData.Model) { %>  
   <span class="image">  
        <a href="images/<%= each_portrait_image.Path %>">  
        <img src="images/<%= each_portrait_image.Path %>" height="100" width="100" /></a>   
        <span class="description"><%= each_portrait_image.Description %></span>  
   </span>  
<% }%>  
   
</asp:Content>

   


