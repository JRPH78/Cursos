import express from "express";
import db from "./config/db";
import colors from "colors";
import router from "./router";

async function connectDB() {
  try {
    await db.authenticate();
    db.sync();
    console.log("la base de datos se conectó correctamente.".magenta.bold);
  } catch (error) {
    console.error(colors.bgRed("hubo un error:"), error);
  }
}

connectDB();

//Instancias de expreesss
const server = express();

server.use(express.json());

//ROUTING
server.get("/", (req, res) => {
  res.json({ message: "Hello, World!" });
});

server.use("/api/products", router);

export default server;
