using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Reciept
{
    public int Id { get; set; }
    public double TotalAmount { get; set; }
    public string Reference { get; set; }
    public List<RecieptsProduct> Orders { get; set; }

}


public class RecieptsProduct
{
    public int Id { get; set; }
    public int RcptId { get; set; }
    [ForeignKey("RcptId")]
    public Reciept RecieptsDetails { get; set; }
    public int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product ProductDetails { get; set; }
    public double Price { get; set; }

}


public class Product
{
    public int Id { get; set; }
    public string ProductNumber { get; set; }
    public string ProductDescription { get; set; }
    public string Price { get; set; }

}