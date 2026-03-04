
select * from customers,orders


select first_name,last_name, order_id,order_date,order_status from customers as c inner join orders as o on c.customer_id=o.customer_id
where order_status=1 or order_status=4 order by order_date desc