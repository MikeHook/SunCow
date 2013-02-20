SunCow
======

A prototype custom gift card site

To run this application:
- Create a database called SunCow 
- Restore from the backup in the Database folder
- Update the NHibernate.config connection.connection_string to point to your database, with a permitted user

Interesting Bits
- Custom routes for card categories and cards
- Razor views (new to me)
- Shared view reuse for CategoriesMenu


Limitations
- Category / card route names should be unique
- No authentication system, custom cards viewable by anyone
- Basic page layouts