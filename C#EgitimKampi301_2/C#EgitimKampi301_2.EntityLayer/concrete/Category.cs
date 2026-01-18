using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampi301_2.EntityLayer.concrete
{
    public class Category
    { 
        //tablonun primary key oldugunu anlaması icin tabloAdıId olmasi lazım
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        // Productın bir tane categorysi olur ama kategorinin birden fazla productı olabilir
        // O yuzden bu tarafa coğul diğerine tekil ekledik
        // yani code firstte many to one relation
        public List<Product> Products { get; set; } 
    }
}

/*
 
 Field- variable-propert
public class Category{
    int x ; -> bu bir field cunku sınıfın icinde
    int x { get; set; } -> buna get set verirsen propert olur
}
method icinde int x dersen de variable oluyor

 */
