import Header from "./Components/header";
import MenuItem from "./Components/MenuItem";
import OrderContent from "./Components/OrderContent";
import { menuItems } from "./db/menuItems";
import useOrder from "./hooks/useOrder";
function App() {
  // console.log({ menuItems });
  const { order, addItem } = useOrder();
  return (
    <>
      <Header />
      <main className="max-w-7/12 mx-auto py-20 grid md:grid-cols-2">
        <div className="p-5">
          <h2 className="font-black text-4xl">Menú</h2>
          <div className="mt-10 space-y-3">
            {menuItems.map((item) => (
              <MenuItem key={item.id} item={item} addItem={addItem} />
            ))}
          </div>
        </div>
        <div className="border border-dashed border-slate-300 p-5 rounded-lg space-y-10">
          <h2 className="font-black text-4xl">Consumo</h2>
          <OrderContent order={order} />
        </div>
      </main>
    </>
  );
}

export default App;
