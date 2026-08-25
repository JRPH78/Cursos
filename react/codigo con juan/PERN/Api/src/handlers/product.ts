import { Request, Response } from "express";
import Product from "../models/Product.model";

export const GetProducts = async (req: Request, res: Response) => {
  try {
    const products = await Product.findAll({
      order: [["id", "ASC"]],
      limit: 10,
      attributes: { exclude: ["createdAt", "updatedAt"] },
    });
    return res.json({ data: products });
  } catch (ex) {
    console.error(ex);
  }
};
export const GetProductById = async (req: Request, res: Response) => {
  try {
    const id = Number(req.params.id);
    const product = await Product.findByPk(id);

    if (!product) {
      return res.status(404).json({ error: "Producto no encontrado" });
    }
    return res.status(200).json({ data: product });
  } catch (ex) {
    console.error(ex);
  }
};

export const CreateProduct = async (req: Request, res: Response) => {
  // Implementation for creating a product
  // console.log("Creating product with data:", req.body);
  try {
    const product = await Product.create(req.body);
    res.status(201).json({ message: "Product created successfully", data: product });
  } catch (error) {
    console.error(error);
  }
};
export const UpdateProduct = async (req: Request, res: Response) => {
  try {
    const id = Number(req.params.id);
    const product = await Product.findByPk(id);

    if (!product) {
      return res.status(404).json({ error: "Producto no encontrado" });
    }
    await product.update(req.body);
    await product.save();

    return res.status(200).json({ data: product });
  } catch (ex) {
    console.error(ex);
  }
};
export const UpdateDisponibilidad = async (req: Request, res: Response) => {
  try {
    const id = Number(req.params.id);
    const product = await Product.findByPk(id);

    if (!product) {
      return res.status(404).json({ error: "Producto no encontrado" });
    }
    product.disponible = Boolean(req.body.disponible);
    await product.save();

    return res.status(200).json({ data: product });
  } catch (ex) {
    console.error(ex);
  }
};

export const DeleteProduct = async (req: Request, res: Response) => {
  try {
    const id = Number(req.params.id);
    const product = await Product.findByPk(id);

    if (!product) {
      return res.status(404).json({ error: "Producto no encontrado" });
    }
    await product.destroy();

    return res.status(200).json({ data: product });
  } catch (ex) {
    console.error(ex);
  }
};
