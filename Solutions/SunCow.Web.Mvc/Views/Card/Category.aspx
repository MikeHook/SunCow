<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CategoryModel>" MasterPageFile="~/Views/Shared/Site.Master" %>

<asp:Content ID="menuContent" ContentPlaceHolderID="Menu" runat="server">
	<%Html.RenderAction("CategoriesMenu", "Card"); %>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="category">
	<h2><%:Model.CategoryName %></h2>
    <h3>Select a card from this category to personalise</h3>
	<%foreach (var card in Model.Cards) {%>
		<div class="card">
			<a href="<%= Url.Action("Details", "Card", new {cardName = card.CardName}) %>">
				<img src="<%= card.ThumbnailImagePath %>" alt="<%:card.CardName %>" />	
			</a>		
			<h3><%=Html.ActionLink<CardController>(c => c.Details(card.CardRouteName), card.CardName) %> </h3>
			<p><%=card.Description %> </p>
			<p><%=string.Format("{0:C2}", card.Price) %></p>
		</div>
		<div class="clear"></div>

    <%} %>
</div>
</asp:Content>
