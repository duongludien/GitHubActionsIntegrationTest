using System.Data;
using Npgsql;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Connect to PostgreSQL
        using var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=NoPassword1;Database=TestDB");
        
        connection.Open();
        Assert.Equal(ConnectionState.Open, connection.State);
        
    }
}