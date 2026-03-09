use EcommAppDb


select p.product_name,b.brand_name,c.category_name,p.model_year,p.list_price
from products p
JOIN brands b 
on p.brand_id = b.brand_id
join categories c 
on p.category_id = c.category_id;

select *
from customers
where city = 'Longview';

select c.category_name,
count(p.product_id) as total_products
from categories c
left join products p
on c.category_id = p.category_id
group by c.category_name;