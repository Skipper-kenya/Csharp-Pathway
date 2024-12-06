// List<T> and Arrays



//declaration
var technologies = new List<string>();
technologies.Add("JavaScript");
technologies.Add("C#");

foreach (var tech in technologies)
{
    Console.WriteLine(tech);
};

//declaration with assignment
var friends = new List<string> { "Elvis", "Peter", "Allan" };



foreach (var friend in friends)
{
    Console.WriteLine(friend);
};


/**********************************************************
SORTING
******************************************************************************************************/

var numbers = new List<int> { 1, 2, 55, 38, 23, 09, 56, 35, 89, 99 };
numbers.Sort();

foreach (var number in numbers)
{
    Console.WriteLine(number);
};
