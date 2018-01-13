﻿using System;
using System.Collections.Generic;
using System.Text;
using Shop.Core.Domain;
using System.Linq;

namespace Shop.Core.Repositories
{
    class ProductRepository : IProductRepository

    {
        private readonly ISet<Product> _products = new HashSet<Product>();


        public Product Get(Guid id)
            => _products.SingleOrDefault(x => x.Id == id);

        public void Add(Product product)
            => _products.Add(product);



        public IEnumerable<Product> GetAll()
            => _products;
        
    }
}
