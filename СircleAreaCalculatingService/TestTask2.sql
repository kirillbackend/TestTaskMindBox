select p.Name as 'Products Name', c.Name as '�ategory Name' from Products as p
left join Products�ategory as pc on p.Id = ProductsId 
left join �ategory as c on pc.�ategoryId = c.Id

