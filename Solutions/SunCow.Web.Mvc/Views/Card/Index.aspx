<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site.Master" %>

<asp:Content ID="menuContent" ContentPlaceHolderID="Menu" runat="server">
	<%Html.RenderAction("CategoriesMenu", "Card"); %>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h1>SunCow personalised gift cards</h1>
    <h3>How does this work?</h3>
    <p>
		Welcome to suncow.com your one stop shop for personalised gift cards.<br />
		Follow these three simple steps to generate your personalised card:
		<ol>
			<li>Choose a card from one of our categories</li>
			<li>Enter your custom messages</li>
			<li>Generate a one of a kind gift card for that special occasion</li>
		</ol>       
    </p>
</asp:Content>
