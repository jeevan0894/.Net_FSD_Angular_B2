select * from stores,orders,order_items

select store_name,sum(quantity * list_price * (1 - discount))as total_sales from stores as s inner join orders as o 
on s.store_id=o.store_id
inner join order_items as oi
on o.order_id =oi.order_id
where order_status=4 
group by store_name
order by total_sales desc