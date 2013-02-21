<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CardModel>" MasterPageFile="~/Views/Shared/Site.Master" %>

<asp:Content ID="menuContent" ContentPlaceHolderID="Menu" runat="server">
	<%Html.RenderAction("CategoriesMenu", "Card"); %>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="card-page">
	<h2><%:Model.CardName %></h2>
    <h3>Enter you personal messages for this card</h3>

		<div class="card">
			<img src="<%= Model.OutsideImagePath %>" alt="<%:Model.CardName %>" />
			
			<img src="<%= Model.InsideImagePath %>" alt="<%:Model.CardName %>" />		
			<p><%=Model.Description %> </p>
			<p><%=string.Format("{0:C2}", Model.Price) %></p>			
		</div>	

		<% using (Html.BeginForm("PersonaliseCard", "Personalise", FormMethod.Post))
	 { %>
			<%= Html.Hidden("CardRouteName", Model.CardRouteName)%>
			
			<p>
			<%=Html.Label("Salutation") %>
			<%= Html.TextBox("Salutation")%>
			</p>

			<p>
			<%=Html.Label("OutsideMessage")%>
			<%= Html.TextBox("OutsideMessage")%>
			</p>

			<p>
			<%=Html.Label("InsideMessage")%>
			<%= Html.TextBox("InsideMessage")%>
			</p>

			<p>
			<%=Html.Label("SignOff")%>
			<%= Html.TextBox("SignOff")%>
			</p>
       
			<input type="submit" value="Generate my card" />
		<% } %>



</div>
</asp:Content>
