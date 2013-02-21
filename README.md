SunCow
======

A prototype personalised gift card site

To run this application:
- Create a database called SunCow 
- Restore from the backup in the Database folder
- Update the NHibernate.config connection.connection_string to point to your database, with a permitted user

Interesting Bits
- Sharp architecture base project used to provide quick setup of loosely coupled architecture
- Custom routes for card categories and cards
- Shared view reuse for CategoriesMenu
- Card images are generated dynamically 

Limitations
- Dependancy on Sharp architecture libraries
- Category / card route names should be unique
- No authentication system, custom cards viewable by anyone
- Basic page layouts
- No form validation
- No custom cards listing
- Image generator only works if the directory is available