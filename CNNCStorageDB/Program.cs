// See https://aka.ms/new-console-template for more information
using CNNCStorageDB;
using CNNCStorageDB.Data;

Console.WriteLine($"{DateTime.Now.AddHours(8)}");

CNNCDbContext db = new CNNCDbContext();

CNNCDbQueries queries = new CNNCDbQueries(db);

//var result = await queries.GetAllWorkers();

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.FirstName} {item.MiddleName} {item.LastName} {item.Position.Name} {item.Location.Name}");
//}
