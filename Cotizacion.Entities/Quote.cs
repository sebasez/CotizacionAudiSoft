using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cotizacion.Entities
{
    public class Quote : Entitie
    {
        public string RUC { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tax { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
