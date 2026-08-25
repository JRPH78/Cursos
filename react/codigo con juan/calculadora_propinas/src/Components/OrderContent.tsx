import type { OrderItem } from "../types/MenuItems";

type OrderContentProps = {
  order: OrderItem[];
};
export default function OrderContent({ order }: OrderContentProps) {
  console.log(order);
  return (
    <>
      {order.length === 0 ? (
        <p>la orden esta vacia</p>
      ) : (
        order.map((item) => (
          <div key={item.id}>
            <p className="text-lg">
              {item.name} - ${item.price}
            </p>
            <p className="font-black">
              Cantidad: {item.cantidad} - ${item.cantidad * item.price}
            </p>
          </div>
        ))
      )}
    </>
  );
}
