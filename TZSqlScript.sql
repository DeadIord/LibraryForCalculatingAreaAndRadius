﻿SELECT P.ProductName, COALESCE(C.CategoryName, 'Без категории') AS CategoryName
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID;