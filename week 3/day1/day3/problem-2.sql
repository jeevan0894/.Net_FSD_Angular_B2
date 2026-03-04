select * from products,categories,brands

select product_name,category_name,brand_name,model_year,list_price 
from products as p inner join categories as c 
on p.category_id =c.category_id 
inner join brands as b 
on  b.brand_id=p.brand_id 
where list_price>500 
order by list_price 