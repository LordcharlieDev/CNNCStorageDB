// See https://aka.ms/new-console-template for more information
using CNNCStorageDB;
using CNNCStorageDB.Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine($"{DateTime.Now.AddHours(8)}");

CNNCDbContext db = new CNNCDbContext();


var result = await db.Departments.ToListAsync();

foreach (var item in result)
{
    Console.WriteLine($"{item.Name}");
}
