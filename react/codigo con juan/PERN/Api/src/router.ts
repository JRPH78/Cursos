import { Router } from "express";
import {
  CreateProduct,
  GetProducts,
  GetProductById,
  UpdateProduct,
  UpdateDisponibilidad,
  DeleteProduct,
} from "./handlers/product";
import { body, param } from "express-validator";
import ValidateProduct from "./middleware";

const router = Router();
// router.get("/", (req, res) => {
//   res.json({ message: "Hello, Worlddddd!" });
// });
router.get("/", GetProducts);

router.get(
  "/:id",
  param("id").isInt().withMessage("ID no valido"),
  ValidateProduct,
  GetProductById,
);

router.post(
  "/",

  body("nombre").notEmpty().withMessage("El Nombre del producto no puede esta vacio "),
  body("precio")
    .notEmpty()
    .withMessage("El Precio del producto no puede esta vacio ")
    .isNumeric()
    .withMessage("El Precio debe ser un valor valido ")
    .custom((value) => value > 0)
    .withMessage("el Precio debe ser mayor a 0"),

  ValidateProduct,

  CreateProduct,
);

router.put(
  "/:id",
  param("id").isInt().withMessage("ID no valido"),

  body("nombre").notEmpty().withMessage("El Nombre del producto no puede esta vacio "),
  body("precio")
    .notEmpty()
    .withMessage("El Precio del producto no puede esta vacio ")
    .isNumeric()
    .withMessage("El Precio debe ser un valor valido ")
    .custom((value) => value > 0)
    .withMessage("el Precio debe ser mayor a 0"),
  body("disponible").isBoolean().withMessage("Valor de disponibilidad Invalido"),

  ValidateProduct,
  UpdateProduct,
);
router.patch(
  "/:id",
  param("id").isInt().withMessage("ID no valido"),

  body("disponible").isBoolean().withMessage("Valor de disponibilidad Invalido"),

  ValidateProduct,
  UpdateDisponibilidad,
);

router.delete(
  "/:id",
  param("id").isInt().withMessage("ID no valido"),

  ValidateProduct,
  DeleteProduct,
);

export default router;
