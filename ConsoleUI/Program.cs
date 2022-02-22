using DRYDemoLibrary;

Console.Write("What is your first name: ");
string firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string lastName = Console.ReadLine();

EmployeeProcessor processor = new EmployeeProcessor();
string employeeID = processor.GenerateEmployeeID(firstName, lastName);

Console.WriteLine($"Your employee ID is: {employeeID}");

Console.ReadLine();
