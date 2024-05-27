using System.Text.RegularExpressions;
using Technology;


//Instantiate the smartphone from SmartPhones class
SmartPhone pixel = new SmartPhone(6, 128, 4000, false, 2020);
pixel.TakeSelfie();
pixel.UseHours(3);
pixel.ChargeHours(1.5);
pixel.TakeSelfie();
Console.WriteLine(pixel);


//Instantiate the laptop from Laptop class
Laptop zenbook = new Laptop(8, 256, 7500, false, 6);
zenbook.UseHours(5);
zenbook.AddStorage(256);
zenbook.IncreaseRam(8);
zenbook. ChargeHours(2.2);
Console.WriteLine(zenbook);

