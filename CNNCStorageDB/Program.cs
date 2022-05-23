// See https://aka.ms/new-console-template for more information
using CNNCStorageDB;
using CNNCStorageDB.Data;

Console.WriteLine("Hello, World!");

CNNCDbContext db = new CNNCDbContext();

CNNCDbQueries queries = new CNNCDbQueries(db);

var result = queries.GetAllWorkers();

foreach (var item in result)
{
    Console.WriteLine($"{item.FirstName} {item.MiddleName} {item.LastName} {item.Position.Name} {item.Location.Name}");
}
