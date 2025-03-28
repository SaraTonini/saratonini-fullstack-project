var builder = WebApplication.CreateBuilder(args);

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Use CORS
app.UseCors();

var products = new[]
{
    new
    {
        Id = 1,
        Name = "Laptop",
        Price = 1200.50,
        Stock = 25,
        Category = new
        {
            Id = 101,
            Name = "Electronics"
        }
    },
    new
    {
        Id = 2,
        Name = "Headphones",
        Price = 50.00,
        Stock = 100,
        Category = new
        {
            Id = 102,
            Name = "Accessories"
        }
    }
};

app.MapGet("/api/productlist", () =>
{
    return products; // Return cached product data
});

app.Run();
