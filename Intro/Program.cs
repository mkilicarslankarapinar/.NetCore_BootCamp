// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 1000;

// variables
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton --> Hoşgeldin Kılıç");
}
else
{
    Console.WriteLine("Buton --> Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6", };

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

// strat condition      //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net 8 vs...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java 17 ...";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12  ...";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

//CourseManager courseManager = new CourseManager();
//courseManager.GetAll();

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 1;
customer2.NationalIdentity = "12345678922";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CoorporateCustomer Customer3 = new CoorporateCustomer();
Customer3.Id = 3;
Customer3.Name = "Kodlama.io";
Customer3.CustomerNumber = "654778";
Customer3.TaxNumber = "12345678921";

CoorporateCustomer Customer4 = new CoorporateCustomer();
Customer4.Id = 3;
Customer4.Name = "abc";
Customer4.CustomerNumber = "654779";
Customer4.TaxNumber = "12345678929";

//value type --> int, bool, double...
//reference types --> array, class, interface...
string[] cities1 = { "a", "i", "i2" };
string[] cities2 = { "b", "b2", "d" };

cities1 = cities2;
cities1[0] = "adana";
Console.WriteLine(cities2[0]);

BaseCustomer[] customers = {customer1, customer2, Customer3, Customer4};

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

