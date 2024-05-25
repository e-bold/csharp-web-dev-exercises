//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

int[] numbers = {1, 1, 2, 3, 5, 8};

foreach(int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("------------");


for (int i = 0; i < numbers.Length; i++) {
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("------------");

//Prints odd ones
foreach(int num in numbers) {
  
    if (num % 2 != 0 ) {

    Console.WriteLine(num);
    }
}


