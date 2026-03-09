select concat(product_name, ' (', model_year, ')') as product_info,list_price,
(list_price -(select AVG(p2.list_price) from products p2 where p2.category_id = p1.category_id)) 
as price_difference from products p1
where list_price >(select AVG(p2.list_price) from products p2 where p2.category_id = p1.category_id);