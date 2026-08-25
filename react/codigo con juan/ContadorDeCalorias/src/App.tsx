import Form from "./components/Form";
import "./App.css";

function App() {
  return (
    <>
      <header className="bg-teal-100 py-4 px-8">
        <div className="text-center">
          <h1 className="text-3xl font-bold">Contador de Calorías</h1>
        </div>
      </header>
      <section>
        <Form />
      </section>
    </>
  );
}

export default App;
