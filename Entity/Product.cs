using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shop.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int IdNameCategory { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }       
    }

    public class ResultJoin
    {
        [Key]
        public string NameProduct { get; set; }
        public string NameCategory { get; set; }
    }
}
