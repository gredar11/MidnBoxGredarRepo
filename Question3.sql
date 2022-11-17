SELECT Products.ProductName, Categories.CategoryName from Products 
left join ProductsCategories on ProductsCategories.ProductID = Products.ProductID 
left join Categories on ProductsCategories.CategoryID = Orders.CategoryID;