### Microsoft Access scaffold Builder

This is a work in progress to work with the following provider

https://www.nuget.org/packages/EntityFrameworkCore.Jet/

**Example**

Scaffold-DbContext "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb" -Provider EntityFrameworkCore.Jet -OutputDir NorthModels -Context NorthWindContext  -v -f  -startupproject Datalibrary -ContextDir Contexts -t "Contacts","ContactType","Countries","Customers"
