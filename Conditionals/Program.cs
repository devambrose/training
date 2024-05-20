// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
 * if conditions 
 * 
 * grading system 
 */

int grade = 0;



//we use the ABCD gradin system

/** if and else 
 * if ,else if and else
 *  > = 80 A 80 81 82 -> 100
 *  > = 70 B < 80   70 71 72 79
 *  >  50 C 51 52-> 69
 *  < = 50 D
 * and &&
 * 
 * or ||
 * 
 * true | true -> true
 * true | false -> true
 * false | false -> false
 * 
 * true & true -> true
 * true & false -> false
 * false & false -> false
 * 
 * switch case 
 */

while (true)
{

    Console.WriteLine("Please input your grade");

    string gradeString = Console.ReadLine();

    grade = Int32.Parse(gradeString);


    if(grade >= 80)
    {
        Console.WriteLine("A");
    }else if( (grade < 80 |  grade >= 70) & grade < 75)
    {
        Console.WriteLine("B");
    }
    else
    {
        Console.WriteLine("D");
    }
}

