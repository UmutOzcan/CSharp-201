
List<Category> categories =
[
    new Category{CategoryId= 1,CategoryName="Bilgisayar"},
    new Category{CategoryId= 2,CategoryName="Telefon"}
];

List<Product> products =
[
    new Product{ProductId=1,CategoryId=1,ProductName="Monster Laptop",QuantityPerUnit="64 GB RAM",UnitPrice=20000,UnitInStock=5},
    new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitInStock=3},
    new Product{ProductId=3,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=5000,UnitInStock=2},
    new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=20000,UnitInStock=1},
    new Product{ProductId=5,CategoryId=2,ProductName="Monster Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=20000,UnitInStock=0},
];




foreach (var product in GetProducts(products))
{
    Console.WriteLine(product.ProductName + " " + product.QuantityPerUnit);
}
Console.WriteLine();
foreach (var product in GetProductsLinq(products))
{
    Console.WriteLine(product.ProductName + " " + product.QuantityPerUnit);
}


Console.ReadKey();

// Algoritmik
static List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredProduct = [];
    foreach (var product in products)
    {
        if (product.UnitPrice > 10000 && product.UnitInStock > 0)
            filteredProduct.Add(product);
    }
    return filteredProduct;
}

// Linq
static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(p => p.UnitPrice > 10000 && p.UnitInStock > 0).ToList();
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}