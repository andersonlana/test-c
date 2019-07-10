using BelezaNaWebTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelezaNaWebTest.DLL.Services
{
    public static class ProductService
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product
            {
                Sku = 43264,
                Name = "L'Oréal Professionnel Expert Absolut Repair Cortex Lipidium - Máscara de Reconstrução 500g",
                Inventory = new Inventory
                {
                    Warehouses = new List<Warehouse>()
                    {
                        new Warehouse
                        {
                            Locality = "SP",
                            Quantity = 12,
                            Type = Warehousetypes.ECOMMERCE
                        },
                        new Warehouse
                        {
                            Locality = "MOEMA",
                            Quantity = 3,
                            Type = Warehousetypes.PHYSICAL_STORE
                        }
                    }
                }
            }
        };

        public static void Create(Product product)
        {
            if (Get(product.Sku) != null)
            {
                throw new Exception($"O produto {product.Sku} já foi cadastrado.");
            }

            Products.Add(product);
        }

        public static void Edit(Product product)
        {
            foreach (var item in Products)
            {
                if (item.Sku == product.Sku)
                {
                    item.Name = product.Name;
                    item.Inventory = product.Inventory;

                    break;
                }
            }
        }

        public static Product Get(int sku)
        {
            return Products.FirstOrDefault(x=> x.Sku == sku);
        }

        public static void Delete(int sku)
        {

            var product = Get(sku);
            Products.Remove(product);
        }

        public static List<Product> GetAll()
        {
            return Products;
        }
    }
}
