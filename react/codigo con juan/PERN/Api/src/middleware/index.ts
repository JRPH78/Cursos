import { Request, Response, NextFunction } from "express";
import { validationResult } from "express-validator";

export default function ValidateProduct(req: Request, res: Response, next: NextFunction) {
  let errors = validationResult(req);
  //   console.log({ errors });

  //   console.log(errors.isEmpty());
  if (!errors.isEmpty()) {
    console.log("hay errores");
    return res.status(500).json({ errors: errors.array() });
  }
  next();
}
