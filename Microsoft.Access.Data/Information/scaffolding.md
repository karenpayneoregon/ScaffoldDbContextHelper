
# Entity Framework Core working with Microsoft Access
Using NuGet package [EntityFrameworkCore.Jet](https://www.nuget.org/packages/EntityFrameworkCore.Jet/). 

[Git repository](https://github.com/bubibubi/EntityFrameworkCore.Jet).

PM> Scaffold-DbContext "**Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb**" **-Provider EntityFrameworkCore.Jet** -OutputDir NorthModels -Context NorthWindAzureForInsertsContext  -v -f  -startupproject Microsoft.Access.Data -ContextDir Contexts -t "Contacts","ContactType","Countries","Customers"

NuGet package [Equin.ApplicationFramework.BindingListView](https://www.nuget.org/packages/Equin.ApplicationFramework.BindingListView/) is used for providing sort and filtering in a DataGridView.