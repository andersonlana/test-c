using BelezaNaWebTest.DLL.Services;
using BelezaNaWebTest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BelezaNaWebTest.UnitTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Create()
        {
            Product product = new Product
            {
                Sku = 57566,
                Name = "Wella Professionals Invigo Nutri-Enrich - Shampoo 1000ml",
                Inventory = new Inventory
                {
                    Warehouses = new List<Warehouse>()
                    {
                        new Warehouse
                        {
                            Locality = "RJ",
                            Quantity = 0,
                            Type = Warehousetypes.ECOMMERCE
                        },
                        new Warehouse
                        {
                            Locality = "MOEMA",
                            Quantity = 0,
                            Type = Warehousetypes.PHYSICAL_STORE
                        }
                    }
                }
            };

            ProductService.Create(product);
            LogAllProducts();
        }

        [TestMethod]
        public void Edit()
        {
            Product product = new Product
            {
                Sku = 43264,
                Name = "L'Oréal Professionnel Expert Absolut Repair Cortex Lipidium - Máscara de Reconstrução 1000g",
                Inventory = new Inventory
                {
                    Warehouses = new List<Warehouse>()
                    {
                        new Warehouse
                        {
                            Locality = "RJ",
                            Quantity = 4,
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
            };

            ProductService.Edit(product);
            LogAllProducts();
        }

        [TestMethod]
        public void Get()
        {
            Product product = ProductService.Get(43264);
            Console.WriteLine(JsonConvert.SerializeObject(product));
        }

        [TestMethod]
        public void Delete()
        {
            ProductService.Delete(43264);
            LogAllProducts();
        }

        private void LogAllProducts()
        {
            List<Product> products = ProductService.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(products));
        }
    }
}
