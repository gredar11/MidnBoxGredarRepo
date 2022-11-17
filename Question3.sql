SELECT Products.Name, Categories.Name From 
Products LEFT JOIN Categories ON Products.CategoryId = Categories.Id;