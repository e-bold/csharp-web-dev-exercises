using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;
    

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.
FlavorComparer comparer = new FlavorComparer();
availableFlavors.Sort(comparer);

foreach(IceCreamShop.Flavor flavor in availableFlavors)
{
    Console.WriteLine(flavor);
}
    Console.WriteLine(Environment.NewLine);


// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.

ConeComparer comparer1 = new ConeComparer();
availableCones.Sort(comparer1);


foreach(IceCreamShop.Cone cone in availableCones)
{
    Console.WriteLine(cone.Name + " " + cone.Cost + " " + cone.ToString());
}

// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.


