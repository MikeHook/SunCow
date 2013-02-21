<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CategoriesMenuModel>" %>

<ul>
<% foreach (var categoryLink in Model.CategoryLinks) { %>
	<li><a href="<%=categoryLink.Value%>"><%:categoryLink.Key%></a></li>
<%} %>
</ul>