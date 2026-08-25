import { categorias } from "../data/categories";

export default function Form() {
  return (
    <>
      <form className="space-y-5 bg-white shadow p-10 rounded-lg">
        <div className="grid grid-cols-1 gap-3">
          <h2 className="text-2xl font-bold">Agregar alimento</h2>
          <label htmlFor="nombre">Nombre:</label>
          <input type="text" id="nombre" name="nombre" />
          <label htmlFor="calorias">Calorías:</label>
          <input type="number" id="calorias" name="calorias" />
          <label htmlFor="categoria">Categoría:</label>
          <select id="categoria" name="categoria">
            <option value="">Seleccionar categoría</option>
            {categorias.map((cat) => (
              <option key={cat.id} value={cat.id}>
                {cat.nombre}
              </option>
            ))}
          </select>
          <button type="submit">Agregar</button>
        </div>
      </form>
    </>
  );
}
