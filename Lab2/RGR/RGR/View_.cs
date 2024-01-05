﻿using Microsoft.EntityFrameworkCore;
using RGR.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR
{
    public class View_
    {
        #region Base 
        public void Menu()
        {
            Console.WriteLine("Inventarization of the warehouse\n ");
            Console.WriteLine("Choose the table: ");
            string[] tables = new string[6] { "Product", "Category", "City", "Manufacturer", "Warehouse", "Warehouse Product" };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i + 1 + ". " + tables[i]);
            }

            Console.WriteLine("Enter 0 to exit\n ");
        }
        public void TableMenu()
        {
            string[] options = new string[5] { "Show all", "Input", "Edit", "Delete", "Search" };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" " + (i + 1).ToString() + ". " + options[i]);
            }

            Console.WriteLine("Enter 0 to exit\n ");
        }
        public void ErrorMessage(string message)
        {
            Console.WriteLine("  " + message);

            Console.WriteLine("  Press any key to continue\n");
            Console.ReadKey();
        }
        public void Message(string message)
        {
            Console.WriteLine("  " + message);
        }
        public void Done()
        {
            Console.WriteLine("  Operation is successful! \n  Press any key to continue\n");
            Console.ReadKey();
        }
        #endregion
        #region Products
        public void ShowAllProducts(List<Prod> Products)
        {
            Console.WriteLine("{0,3}|{1,25}|{2,10}|{3,10}|{4,10}|{5,7}|{6,15}|{7,15}", "Id", "Name", "Vend.code", "Ser.num", "Deliv.date", "Count", "Manufacturer", "Category");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            foreach (Prod p in Products)
            {
                Console.WriteLine("{0,3}|{1,25}|{2,10}|{3,10}|{4,10}|{5,7}|{6,15}|{7,15}", p.Id, p.Name, p.Vendor_code, p.Serial_number, Convert.ToString(p.Delivery_date), p.Quantity, p.Manufacturer_Id, p.Category_Id);
            }
        }
        public Prod ProductInput()
        {
            Prod prod = new Prod();
            Console.WriteLine("  Enter the data about new product: ");
            Console.Write("  Name:  ");
            prod.Name = Console.ReadLine();
            //
            Console.Write("  Vendor Code:  ");
            prod.Vendor_code = Console.ReadLine();
            //
            Console.Write("  Serial Number:  ");
            prod.Serial_number = Console.ReadLine();
            //
            Console.Write("  Delivery Date:  ");
            prod.Delivery_date = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));
            //
            Console.Write("  Quantity:  ");
            prod.Quantity = Convert.ToInt32(Console.ReadLine());
            //
            Console.Write("  Manufacturer:  ");
            prod.Manufacturer_Id = Convert.ToInt32(Console.ReadLine());
            //
            Console.Write("  Category:  ");
            prod.Category_Id = Convert.ToInt32(Console.ReadLine());
            //
            return prod;
        }
        public void ProductSearchMenu()
        {
            Console.WriteLine("  Choose the column as the criteria of the search:");
            Console.WriteLine("  1. Name");
            Console.WriteLine("  2. Vendor code");
            Console.WriteLine("  3. Serial number");
            Console.WriteLine("  4. Quantity");
        }
        public string ProductNameSearch()
        {
            Console.WriteLine("  Enter the name (or its part)");
            string str = Console.ReadLine();
            return str;
        }
        public string ProductSearchVendorCode()
        {
            Console.WriteLine("  Enter the vendor code (or its part)");
            string str = Console.ReadLine();
            return str;
        }
        public string ProductSearchSerialNumber()
        {
            Console.WriteLine("  Enter the serial number (or its part)");
            string str = Console.ReadLine();
            return str;
        }

        #endregion
        #region Manufacturers
        public void ShowAllManufacturers(List<Manuf> manufs)
        {
            Console.WriteLine("{0,3}|{1,15}", "Id", "Name");
            Console.WriteLine("---------------------");
            foreach (Manuf m in manufs)
            {
                Console.WriteLine("{0,3}|{1,15}", m.Id, m.Name);
            }
        }
        public Manuf ManufacturerInput()
        {
            Manuf man = new Manuf();
            Console.WriteLine("  Enter the name of new manufacturer: ");
            Console.Write("  Name:  ");
            man.Name = Console.ReadLine();
           
            return man;
        }
        public string ManufacturerSearch()
        {
            Console.WriteLine("  Enter the name of manufacturer (or its part)");
            string str = Console.ReadLine();
            return str;
        }
        #endregion
        #region Categories 
        public void ShowAllCategories(List<Categ> cats)
        {
            Console.WriteLine("{0,3}|{1,15}", "Id", "Name");
            Console.WriteLine("---------------------");
            foreach (Categ c in cats)
            {
                Console.WriteLine("{0,3}|{1,15}", c.Id, c.Name);
            }
        }
        public Categ CategoryInput()
        {
            Categ cat = new Categ();
            Console.WriteLine("  Enter the name of new category: ");
            Console.Write("  Name:  ");
            cat.Name = Console.ReadLine();

            return cat;
        }

        public string CategorySearch()
        {
            Console.WriteLine("  Enter the name of category (or its part)");
            string str = Console.ReadLine();
            return str;
        }
        #endregion
        #region Cities
        public void ShowAllCities(List<Cities> cts)
        {
            Console.WriteLine("{0,3}|{1,15}", "Id", "Name");
            Console.WriteLine("---------------------");
            foreach (Cities c in cts)
            {
                Console.WriteLine("{0,3}|{1,15}", c.Id, c.Name);
            }
        }
        public Cities CityInput()
        {
            Cities cts = new Cities();
            Console.WriteLine("  Enter the name of new city: ");
            Console.Write("  Name:  ");
            cts.Name = Console.ReadLine();

            return cts;
        }
        public string CitySearch()
        {
            Console.WriteLine("  Enter the name of city (or its part)");
            string str = Console.ReadLine();
            return str;
        }
        #endregion
        #region Warehouses
        public void ShowAllWarehouses(List<Warehouse> warehouses)
        {
            Console.WriteLine("{0,3}|{1,15}|{2,15}|{3,5}|{4,25}", "Id", "Name", "City", "Sq.ar", "Addres");
            Console.WriteLine("------------------------------------------------------------------");
            foreach (Warehouse w in warehouses)
            {
                Console.WriteLine("{0,3}|{1,15}|{2,15}|{3,5}|{4,25}", w.Id, w.Name, w.City_Id, w.Square_area,  w.Address);
            }
        }
        public Warehouse WarehouseInput()
        {
            Warehouse w = new Warehouse();
            Console.WriteLine("  Enter the data about new warehouse: ");
            Console.Write("  Name:  ");
            w.Name = Console.ReadLine();
            //
            Console.Write("  City:  ");
            w.City_Id = Convert.ToInt32(Console.ReadLine());
            //
            Console.Write("  Square area:  ");
            w.Square_area = Convert.ToDouble(Console.ReadLine());
            //
            Console.Write("  Address:  ");
            w.Address = Console.ReadLine();
            //

            return w;
        }
        public void WarehouseSearchMenu()
        {
            Console.WriteLine("  Choose the column as the criteria of the search:");
            Console.WriteLine("  1. Name");
            Console.WriteLine("  2. Square area");
            Console.WriteLine("  3. Address");
        }
        public string WarehouseNameSearch()
        {
            Console.WriteLine("  Enter the name of warehouse (or its part)");
            string name = Console.ReadLine();
            return name;
        }
        public string WarehouseAddressSearch()
        {
            Console.WriteLine("  Enter the address of warehouse (or its part)");
            string add = Console.ReadLine();
            return add;
        }
        #endregion
        #region WarehousesProducts
        public void ShowAllWarehousesProducts(List<WarehouseProduct> wp)
        {
            Console.WriteLine("{0,3}|{1,15}|{2,25}", "Id", "Warehouse", "Product");
            Console.WriteLine("---------------------------------------------");
            foreach (WarehouseProduct w in wp)
            {
                Console.WriteLine("{0,3}|{1,15}|{2,25}", w.Id, w.Warehouse_Id, w.Product_Id);
            }
        }
        public WarehouseProduct WarehouseProductInput()
        {
            WarehouseProduct w = new WarehouseProduct();
            Console.WriteLine("  Enter the data about warehouse and corresponding product: ");
            Console.Write("  Warehouse:  ");
            w.Warehouse_Id = Convert.ToInt32(Console.ReadLine());
            //
            Console.Write("  Product:  ");
            w.Product_Id = Convert.ToInt32(Console.ReadLine());

            return w;
        }
        public void WarehouseProductSearchMenu()
        {
            Console.WriteLine("  Choose the column as the criteria of the search:");
            Console.WriteLine("  1. Warehouse_Id");
            Console.WriteLine("  2. Product_Id");
        }
        public string WarehouseProductSearchW()
        {
            Console.WriteLine("  Enter the warehouse Id");
            string str = Console.ReadLine();
            return str;
        }
        public string WarehouseProductSearchP()
        {
            Console.WriteLine("  Enter the product Id");
            string str = Console.ReadLine();
            return str;
        }
        #endregion
    }
}
