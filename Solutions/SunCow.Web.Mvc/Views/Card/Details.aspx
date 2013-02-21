﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site.Master" %>

<asp:Content ID="menuContent" ContentPlaceHolderID="Menu" runat="server">
	<%Html.RenderAction("CategoriesMenu", "Card"); %>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>CARD DETAILS</h2>
    <h3>What next?</h3>
    <p>
        Your S#arp Architecture 2.0RC project is now setup and ready to go. This release is built on the RTM verion of ASP.NET MVC 3 and .NET 4. The only tasks remaining
        are to:
        <ol>
            <li>
                <span style="font-weight:bold; font-style:italic">Create your database and set the connection string
                within SunCow.Web.Mvc/NHibernate.config</span>
            </li>
            <li>
                Optionally, modify the Fluent NHibernate preferences within SunCow.Data.NHibernateMaps.GetConventions()
                if you don't like the default settings.  There's lots of terrific info about Fluent NHibernate
                at <a href="http://wiki.fluentnhibernate.org/show/HomePage">http://wiki.fluentnhibernate.org/show/HomePage</a>.
            </li>
            <li>
                Open SunCow.Tests.dll via NUnit and make sure all the tests are turning green.
            </li>
        </ol>
    </p>
    <p>
        If you need direction on what to do next, ask for assitance and guidance on the
        <a href="http://groups.google.com/group/sharp-architecture">S#arp Architecture discussion boards</a>.
    </p>
</asp:Content>