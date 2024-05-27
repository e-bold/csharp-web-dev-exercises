using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

string nl = Environment.NewLine;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.
FlavorComparer comparer = new FlavorComparer();

//Before
Console.WriteLine("Flavor Before: ");
Console.WriteLine(nl);
foreach(IceCreamShop.Flavor flavor in availableFlavors)
{
    Console.WriteLine(flavor);
}
Console.WriteLine(nl);

//Sorting
availableFlavors.Sort(comparer);

//After
Console.WriteLine("Flavor After: ");
Console.WriteLine(nl);
foreach(IceCreamShop.Flavor flavor in availableFlavors)
{
    Console.WriteLine(flavor);
}
Console.WriteLine(nl);


// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
ConeComparer comparer1 = new ConeComparer();

//Before
Console.WriteLine("Cost Before: ");
Console.WriteLine(nl);
foreach(IceCreamShop.Cone cone in availableCones)
{
    Console.WriteLine(cone);
}
Console.WriteLine(nl);


//Sort
availableCones.Sort(comparer1);


//After
Console.WriteLine("Cost After: ");
Console.WriteLine(nl);
foreach(IceCreamShop.Cone cone in availableCones)
{
    Console.WriteLine(cone);
}

// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.




