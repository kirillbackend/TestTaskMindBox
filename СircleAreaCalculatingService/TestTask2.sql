select p.Name as 'Products Name', c.Name as 'Ñategory Name' from Products as p
left join ProductsÑategory as pc on p.Id = ProductsId 
left join Ñategory as c on pc.ÑategoryId = c.Id

