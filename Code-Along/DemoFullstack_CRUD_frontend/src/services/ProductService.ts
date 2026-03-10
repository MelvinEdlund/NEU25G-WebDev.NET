import type { Product } from "../types/Product";

export const baseURL: string = "http://localhost:5269/api/product";

// Denna funktion är generell och kan användas för både POST, PUT och DELETE
const sendRequest = async (product: Product, method: number) => {
  // Här används en ternary operator för att styra vilken typ av anrop som görs
  const httpMethod: string =
    method == 1 ? "POST" : method == 2 ? "PUT" : "DELETE";

  const response = await fetch("baseURL", {
    method: httpMethod,
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(product),
  });

  return response.ok;
};

export const addProduct = async (product: Product) => {
  return await sendRequest(product, 1);
};

export const updateProduct = async (product: Product) => {
  return await sendRequest(product, 2);
};

export const deleteProduct = async (product: Product) => {
  return await sendRequest(product, 3);
};

export const getAllProducts = async () => {
  return await fetch(baseURL).then((response) => response.json());
};
