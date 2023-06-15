using System;

namespace api.Entities;

public class Product
{
    public Guid Id {get; set;}
    public String? Name {get; set;}
    public decimal Price {get; set;}
    
}
