Imports System
Imports EntityFrameworkCore.Jet
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata

Namespace WindowsFormsApp1.Models
	Partial Public Class NorthContext
		Inherits DbContext

		Public Sub New()
		End Sub

		Public Sub New(ByVal options As DbContextOptions(Of NorthContext))
			MyBase.New(options)
		End Sub

		Public Overridable Property Categories() As DbSet(Of Categories)
		Public Overridable Property Customers() As DbSet(Of Customers)
		Public Overridable Property CustomersContactTitle() As DbSet(Of CustomersContactTitle)
		Public Overridable Property Employees() As DbSet(Of Employees)
		Public Overridable Property Orders() As DbSet(Of Orders)
		Public Overridable Property Products() As DbSet(Of Products)
		Public Overridable Property Suppliers() As DbSet(Of Suppliers)
		Public Overridable Property SuppliersContactTitle() As DbSet(Of SuppliersContactTitle)

		Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
			If Not optionsBuilder.IsConfigured Then
				optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NorthWind.accdb")
			End If
		End Sub

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
			modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079")

			modelBuilder.Entity(Of Categories)(Sub(entity)
				entity.HasKey(Function(e) e.CategoryId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.CategoryId).HasName("CategoriesCategoryID")

				entity.Property(Function(e) e.CategoryId).HasColumnName("CategoryID")

				entity.Property(Function(e) e.CategoryName).HasMaxLength(15)
			End Sub)

			modelBuilder.Entity(Of Customers)(Sub(entity)
				entity.HasKey(Function(e) e.CustomerId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.City).HasName("City")

				entity.HasIndex(Function(e) e.CompanyName).HasName("CompanyName")

				entity.HasIndex(Function(e) e.ContactTitleId).HasName("ContactTitleId")

				entity.HasIndex(Function(e) e.Identifier).HasName("Identifier")

				entity.HasIndex(Function(e) e.PostalCode).HasName("PostalCode")

				entity.HasIndex(Function(e) e.Region).HasName("Region")

				entity.Property(Function(e) e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5).ValueGeneratedNever()

				entity.Property(Function(e) e.Address).HasMaxLength(60)

				entity.Property(Function(e) e.City).HasMaxLength(15)

				entity.Property(Function(e) e.CompanyName).IsRequired().HasMaxLength(40)

				entity.Property(Function(e) e.ContactName).HasMaxLength(30)

				entity.Property(Function(e) e.ContactTitle).HasMaxLength(30)

				entity.Property(Function(e) e.ContactTitleId).HasDefaultValueSql("0")

				entity.Property(Function(e) e.Country).HasMaxLength(15)

				entity.Property(Function(e) e.Fax).HasMaxLength(24)

				entity.Property(Function(e) e.Identifier).ValueGeneratedOnAdd()

				entity.Property(Function(e) e.Phone).HasMaxLength(24)

				entity.Property(Function(e) e.PostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.Region).HasMaxLength(15)

				entity.HasOne(Function(d) d.ContactTitleNavigation).WithMany(Function(p) p.Customers).HasForeignKey(Function(d) d.ContactTitleId).HasConstraintName("ContactTitleCustomers")
			End Sub)

			modelBuilder.Entity(Of CustomersContactTitle)(Sub(entity)
				entity.HasKey(Function(e) e.ContactTitleId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.ContactTitleId).HasName("Id")

				entity.Property(Function(e) e.Title).HasMaxLength(255)
			End Sub)

			modelBuilder.Entity(Of Employees)(Sub(entity)
				entity.HasKey(Function(e) e.EmployeeId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.LastName).HasName("LastName")

				entity.HasIndex(Function(e) e.PostalCode).HasName("PostalCode")

				entity.Property(Function(e) e.EmployeeId).HasColumnName("EmployeeID")

				entity.Property(Function(e) e.Address).HasMaxLength(60)

				entity.Property(Function(e) e.City).HasMaxLength(15)

				entity.Property(Function(e) e.Country).HasMaxLength(15)

				entity.Property(Function(e) e.Extension).HasMaxLength(4)

				entity.Property(Function(e) e.FirstName).IsRequired().HasMaxLength(10)

				entity.Property(Function(e) e.HomePhone).HasMaxLength(24)

				entity.Property(Function(e) e.LastName).IsRequired().HasMaxLength(20)

				entity.Property(Function(e) e.PostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.Region).HasMaxLength(15)

				entity.Property(Function(e) e.Title).HasMaxLength(30)

				entity.Property(Function(e) e.TitleOfCourtesy).HasMaxLength(25)
			End Sub)

			modelBuilder.Entity(Of Orders)(Sub(entity)
				entity.HasKey(Function(e) e.OrderId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.CustomerIdOld).HasName("CustomerID")

				entity.HasIndex(Function(e) e.EmployeeId).HasName("EmployeeID")

				entity.HasIndex(Function(e) e.OrderDate).HasName("OrderDate")

				entity.HasIndex(Function(e) e.ShipPostalCode).HasName("ShipPostalCode")

				entity.HasIndex(Function(e) e.ShippedDate).HasName("ShippedDate")

				entity.Property(Function(e) e.OrderId).HasColumnName("OrderID")

				entity.Property(Function(e) e.CustomerIdOld).HasColumnName("CustomerID_OLD").HasMaxLength(5)

				entity.Property(Function(e) e.EmployeeId).HasColumnName("EmployeeID")

				entity.Property(Function(e) e.Freight).HasColumnType("decimal(19, 0)").HasDefaultValueSql("0")

				entity.Property(Function(e) e.ShipAddress).HasMaxLength(60)

				entity.Property(Function(e) e.ShipCity).HasMaxLength(15)

				entity.Property(Function(e) e.ShipCountry).HasMaxLength(15)

				entity.Property(Function(e) e.ShipName).HasMaxLength(40)

				entity.Property(Function(e) e.ShipPostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.ShipRegion).HasMaxLength(15)

				entity.HasOne(Function(d) d.CustomerIdOldNavigation).WithMany(Function(p) p.Orders).HasForeignKey(Function(d) d.CustomerIdOld).HasConstraintName("{19774F92-7578-4FD7-BEAB-7E30924D3DF1}")

				entity.HasOne(Function(d) d.Employee).WithMany(Function(p) p.Orders).HasForeignKey(Function(d) d.EmployeeId).HasConstraintName("EmployeesOrders")
			End Sub)

			modelBuilder.Entity(Of Products)(Sub(entity)
				entity.HasKey(Function(e) e.ProductId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.CategoryId).HasName("ProductsCategoryID")

				entity.Property(Function(e) e.ProductId).HasColumnName("ProductID")

				entity.Property(Function(e) e.CategoryId).HasColumnName("CategoryID")

				entity.Property(Function(e) e.Discontinued).HasColumnType("bit")

				entity.Property(Function(e) e.DiscontinuedDate).HasMaxLength(27)

				entity.Property(Function(e) e.ProductName).HasMaxLength(40)

				entity.Property(Function(e) e.QuantityPerUnit).HasMaxLength(20)

				entity.Property(Function(e) e.SupplierId).HasColumnName("SupplierID")

				entity.Property(Function(e) e.UnitPrice).HasColumnType("decimal(19, 0)")

				entity.HasOne(Function(d) d.Category).WithMany(Function(p) p.Products).HasForeignKey(Function(d) d.CategoryId).HasConstraintName("CategoriesProducts")
			End Sub)

			modelBuilder.Entity(Of Suppliers)(Sub(entity)
				entity.HasKey(Function(e) e.SupplierId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.CompanyName).HasName("CompanyName")

				entity.HasIndex(Function(e) e.PostalCode).HasName("PostalCode")

				entity.HasIndex(Function(e) e.SuppliersTitleId).HasName("SuppliersSuppliersTitleId")

				entity.Property(Function(e) e.SupplierId).HasColumnName("SupplierID")

				entity.Property(Function(e) e.Address).HasMaxLength(60)

				entity.Property(Function(e) e.City).HasMaxLength(15)

				entity.Property(Function(e) e.CompanyName).IsRequired().HasMaxLength(40)

				entity.Property(Function(e) e.ContactName).HasMaxLength(30)

				entity.Property(Function(e) e.ContactTitle).HasMaxLength(30)

				entity.Property(Function(e) e.Country).HasMaxLength(15)

				entity.Property(Function(e) e.Fax).HasMaxLength(24)

				entity.Property(Function(e) e.Phone).HasMaxLength(24)

				entity.Property(Function(e) e.PostalCode).HasMaxLength(10)

				entity.Property(Function(e) e.Region).HasMaxLength(15)

				entity.Property(Function(e) e.SuppliersTitleId).HasDefaultValueSql("0")

				entity.HasOne(Function(d) d.SuppliersTitle).WithMany(Function(p) p.Suppliers).HasForeignKey(Function(d) d.SuppliersTitleId).HasConstraintName("SuppliersContactTitleSuppliers")
			End Sub)

			modelBuilder.Entity(Of SuppliersContactTitle)(Sub(entity)
				entity.HasKey(Function(e) e.SuppliersTitleId).HasName("PrimaryKey")

				entity.HasIndex(Function(e) e.SuppliersTitleId).HasName("SuppliersTitleId")

				entity.Property(Function(e) e.Title).HasMaxLength(255)
			End Sub)
		End Sub
	End Class
End Namespace
