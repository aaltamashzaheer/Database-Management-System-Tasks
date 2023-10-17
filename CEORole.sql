CREATE SERVER ROLE CEORole AUTHORIZATION User_CEO
GRANT SELECT ON [northwind].[dbo].[Employees] TO CEORole
GRANT SELECT ON [northwind].[dbo].[Orders] TO CEORole
GRANT SELECT ON [northwind].[dbo].[Customers] TO CEORole