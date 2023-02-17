using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCandle.Models
{
    public class Candle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public string Length { get; set; }


        public string Origin { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}