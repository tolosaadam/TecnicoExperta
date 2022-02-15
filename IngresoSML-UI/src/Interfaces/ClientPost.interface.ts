import { ClientTableI } from "./ClientTable.interface";
import { ProductI } from "./Product.Interface";

export interface ClientPostI {
    customerId:number,
    codes:string[],
    product:string
}