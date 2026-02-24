
import { cartitem } from "./cartitms.js";
import { totaleachproductprice } from "./cartitms.js";
const total=totaleachproductprice(cartitem);
console.log(`
   ${cartitem.map(
    item =>
      `${item.name} (₹${item.price} × ${item.quantity}) = ₹${item.price *
        item.quantity}`
  ).join("\n")}
  ${total}
    `);