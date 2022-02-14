import { ClientTableI } from "./ClientTable.interface";
import { ProductI } from "./Product.Interface";

export interface ClientPostI {
    client:ClientTableI[],
    products:ProductI[]
}