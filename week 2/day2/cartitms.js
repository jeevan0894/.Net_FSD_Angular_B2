export const cartitem= [
    {name : "laptop", price : 55000, quantity : 1},
    {name : "mouse", price : 800, quantity:2},
    {name : "keyboard", price: 1500, quantity:1}
];

export const totaleachproductprice=item=>item.map(item=>item.price*item.quantity).reduce((total,value)=>total+value);



