// Detta är en typ som matchar det som backend vill och som i sin tur matchar database
export interface Product {
  productid: number;
  productname: string;
  price: number;
}
