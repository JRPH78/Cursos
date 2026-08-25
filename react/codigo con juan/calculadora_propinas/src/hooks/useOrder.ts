import { useState } from "react";
import type { MenuItem, OrderItem } from "../types/MenuItems";

export default function useOrder() {
  const [order, setOrder] = useState<OrderItem[]>([]);
  //   console.log("orden", order);

  const addItem = (item: MenuItem) => {
    const itemExist = order.find((orderItem) => orderItem.id === item.id);
    // console.log("exist=?", itemExist);

    if (itemExist) {
      const updateOrder: OrderItem[] = order.map((orderItem) =>
        orderItem.id === item.id ? { ...orderItem, cantidad: orderItem.cantidad + 1 } : orderItem,
      );
      setOrder(updateOrder);
    } else {
      const newItem: OrderItem = { ...item, cantidad: 1 };
      setOrder([...order, newItem]);
    }
  };

  return {
    order,
    addItem,
  };
}
