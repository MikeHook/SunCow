<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CustomCardModel>" MasterPageFile="~/Views/Shared/Site.Master" %>

<asp:Content ID="menuContent" ContentPlaceHolderID="Menu" runat="server">
	<%Html.RenderAction("CategoriesMenu", "Card"); %>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="card-page">
	<h2><%:Model.CardName %></h2>
    <h3>Here is your customised card</h3>

		<div class="card">
			<img src="<%= Model.OutsideImagePath %>" alt="<%:Model.CardName %>" />
			
			<img src="<%= Model.InsideImagePath %>" alt="<%:Model.CardName %>" />		
			<p><%=Model.Description %> </p>
			<p><%=string.Format("{0:C2}", Model.Price) %></p>			
		</div>
</div>
</asp:Content>
