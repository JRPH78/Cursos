import { Column, DataType, Model, Table, Default } from "sequelize-typescript";

@Table({
  tableName: "products",
})
class Product extends Model {
  @Column({
    type: DataType.STRING(100),
  })
  declare nombre: string;

  @Column({
    type: DataType.FLOAT,
  })
  declare precio: number;

  @Default(true)
  @Column({
    type: DataType.BOOLEAN,
  })
  declare disponible: boolean;
}
export default Product;
