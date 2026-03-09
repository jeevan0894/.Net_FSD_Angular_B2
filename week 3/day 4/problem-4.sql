SELECT 
    p.product_name,
    s.store_name,
    st.quantity AS available_stock,
    SUM(oi.quantity) AS total_quantity_sold
FROM stocks AS st
INNER JOIN products AS p
    ON st.product_id = p.product_id
INNER JOIN stores AS s
    ON st.store_id = s.store_id
LEFT JOIN order_items AS oi
    ON st.product_id = oi.product_id
GROUP BY p.product_name,s.store_name,st.quantity
ORDER BY p.product_name;