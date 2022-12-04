// See https://aka.ms/new-console-template for more information
using CNNCStorageDB.Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine($"{DateTime.Now}");

CNNCDbContext db = new CNNCDbContext();

try
{

    var result = await db.Departments.ToListAsync();
    foreach (var item in result)
    {
        Console.WriteLine($"{item.Name}");
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}