﻿namespace KooliProjekt.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        //sidume product category
        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }

    }
}
