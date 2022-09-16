// See https://aka.ms/new-console-template for more information

using NorthWind;
using ProjectNorthWind;

Console.WriteLine("Hello, Please Fill in the Information Below");
Console.WriteLine("\n");





Console.WriteLine("\n");

Customer aCoustomer1 = new Customer();

Console.WriteLine("Enter The Customer Id");
aCustomer1.CustomerId = Console.ReadLine();
Console.WriteLine("CustomerId: " + aCoustomer1.CustomerId);

Console.WriteLine("Enter The Company Name");
aCustomer1.CompanyName = Console.ReadLine();
Console.WriteLine("CompanyName: " + aCustomer1.CompanyName);

Console.WriteLine("Enter your contact name");
aCustomer1.ContactName = Console.ReadLine();
Console.WriteLine("ContactName: " + aCustomer1.ContactName);

Console.WriteLine("Enter your contact titile");
aCustomer1.ContactTitle = Console.ReadLine();
Console.WriteLine("ContactTitle: " + aCustomer1.ContactTitle);

Console.WriteLine("Enter your address");
aCustomer1.Address = Console.ReadLine();
Console.WriteLine("Adress: " + aCustomer1.Address);

Console.WriteLine("Enter your city");
aCustomer1.City = Console.ReadLine();
Console.WriteLine("City: " + aCustomer1.City);

Console.WriteLine("Enter region region");
aCustomer1.Region = Console.ReadLine();
Console.WriteLine("Region: " + aCoustomer1.Region);

Console.WriteLine("Enter The postal code");
aCustomer1.PostalCode = Console.ReadLine();
Console.WriteLine("PostalCode: " + aCoustomer1.PostalCode);

Console.WriteLine("Enter The country ");
aCustomer1.Country = Console.ReadLine();
Console.WriteLine("Country: " + aCustomer1.Country);

Console.WriteLine("Enter your phone number");
aCustomer1.Phone = Console.ReadLine();
Console.WriteLine("Phone: " + aCustomer1.Phone);

Console.WriteLine("Enter The fax");
aCustomer1.Fax = Console.ReadLine();
Console.WriteLine("Fax: " + aCostomer1.Fax);



Employee aEmployee1 = new Employee();

Console.WriteLine("\n");


Console.WriteLine("Enter Address");
Console.WriteLine("Address: " + aEmployee1.Address);
aEmployee1.Address = Console.ReadLine();

Console.WriteLine("Enter City");
Console.WriteLine("City: " + aEmployee1.City);
aEmployee1.City = Console.ReadLine();

Console.WriteLine("Enter Region");
Console.WriteLine("Region: " + aEmployee1.Region);
aEmployee1.Region = Console.ReadLine();

Console.WriteLine("Enter postal code");
Console.WriteLine("Postal Code: " + aEmployee1.PostalCode);
aEmployee1.PostalCode = Console.ReadLine();

Console.WriteLine("Enter country");
Console.WriteLine("Country: " + aEmployee1.Country);
aEmployee1.Country = Console.ReadLine();

Console.WriteLine("\n");

OrderDetail aOrderDetail1 = new OrderDetail();

Console.WriteLine("Enter Order Id ");
Console.WriteLine("Order Id: " + aOrderDetail1.OrderId);
aOrderDetail1.OrderId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ender Product Id ");
Console.WriteLine("Product ID: " + aOrderDetail1.ProductId);
aOrderDetail1.ProductId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter unit price");
Console.WriteLine("Unit Price: " + aOrderDetail1.UnitPrice);
aOrderDetail1.UnitPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter quantity");
Console.WriteLine("Quantity: " + aOrderDetail1.Quantity);
aOrderDetail1.Quantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the discount");
Console.WriteLine("Discount: " + aOrderDetail1.Discount);
aOrderDetail1.Discount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");

Order aorder1 = new Order();

Console.WriteLine("Enter Order ID");
Console.WriteLine("OrderID: " + aorder1.OrderId);
aorder1.OrderId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Coustomer ID");
Console.WriteLine("Costomer ID: " + aorder1.CustomerId);
aorder1.CustomerId = Console.ReadLine();

Console.WriteLine("Enter Employee Id");
Console.WriteLine("Employee Id: " + aorder1.EmployeeId);
aorder1.EmployeeId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter OrderDate");
Console.WriteLine("Discount: " + aorder1.OrederDate);
aorder1.OrederDate = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Enter Required Date");
Console.WriteLine("Required Date: " + aorder1.RequiredDate);
aorder1.RequiredDate = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Enter Shipped Date");
Console.WriteLine("Shiped Date: " + aorder1.ShippedDate);
aorder1.ShippedDate = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Enter ShipVia");
Console.WriteLine("Ship Via: " + aorder1.ShipVia);
aorder1.ShipVia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Freight");
Console.WriteLine("Freight: " + aorder1.Freight);
aorder1.Freight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" Enter Ship Name");
Console.WriteLine("ship name: " + aorder1.ShipName);
aorder1.ShipName = Console.ReadLine();


Console.WriteLine("Discount: " + aorder1.ShipAddress);
aorder1.ShipAddress = Console.ReadLine();

Console.WriteLine("Discount: " + aorder1.ShipCity);
aorder1.ShipCity = Console.ReadLine();

Console.WriteLine("Discount: " + aorder1.ShipRegion);
aorder1.ShipRegion = Console.ReadLine();

Console.WriteLine("Discount: " + aorder1.ShipPostalCode);
aorder1.ShipPostalCode = Console.ReadLine();

Console.WriteLine("Discount: " + aorder1.ShipCountry);
aorder1.ShipCountry = Console.ReadLine();
























