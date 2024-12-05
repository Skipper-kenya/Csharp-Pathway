//string declaration and interpolation(concattenation);

string firstFriend = "Elvis";

string secondFriend = "Peter";

Console.WriteLine($"My friends are {firstFriend} {secondFriend}");


//searching string methods

//#1: Trim()

string school = "    university of eldoret           ";

school = school.Trim(); //removes both spaces


/* uncomment below when necessary*/

//school = school.TrimStart() => only the starting space

//school = school.TrimEnd() => only the trailing space

//we can remove the trailing , the starting  or both "significant spaces" using the methods below

Console.WriteLine(school);






/************************************
Replace()
// // *********************************************************************/

//Finds the chosen character (old) and replaces it with the (new) character

string expertise = "I have specialized in learning javascript";

expertise = expertise.Replace("javascript", ".net framework");

Console.WriteLine(expertise);


/***********************************
Contains() and (StartsWith() , EndsWith())
********************************************************************/


//returns a boolean (True or False) based on the validity of the condition

string day = "Today is sunday";

Console.WriteLine(day.Contains("Today"));  //returns True

Console.WriteLine(day.Contains("Tommorow"));  //returns False

//StartsWith() , EndsWith()

//checks if the value in play is correct => returns a boolean

Console.WriteLine(day.StartsWith("Tod")); //return true 
Console.WriteLine(day.Contains("Tad")); //returns false



/*************************************************************************
ToUpper()  , ToLower()
***************************************************************************************/

string case1 = "lowercase";
case1 = case1.ToUpper();  // Changes the string to uppercase
Console.WriteLine(case1); // Outputs: "LOWERCASE"


string case2 = "UPPERCASE";
case2 = case2.ToLower(); //changes the case2 string to lowercase
Console.WriteLine(case2); //returns a lowercase "uppercase"



/***************************************************************************
Length
*************************************************************************************/


//returns the length of characters in a strng


string testword = "This is a test word lets see what length we got here";

Console.WriteLine(testword.Length); //52