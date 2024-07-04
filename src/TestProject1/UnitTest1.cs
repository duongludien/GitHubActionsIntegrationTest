using EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql("Host=localhost;Username=postgres;Password=NoPassword1;Database=TestDB");
        });
        
        var serviceProvider = serviceCollection.BuildServiceProvider();
        var dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        
        // Act
        var blogs = dbContext.Blogs.ToList();
        
        // Assert
        Assert.Equal(4, blogs.Count);
    }
}