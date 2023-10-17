CREATE SERVER ROLE SalesRole AUTHORIZATION User_Sales
GRANT SELECT ON [northwind].[dbo].[Orders] TO SalesRole
GRANT SELECT ON [northwind].[dbo].[Customers] TO SalesRole