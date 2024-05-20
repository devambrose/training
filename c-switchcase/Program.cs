//todo : connect to chat GPT 

// emotional feedback 

// emotion -> 

/**
 * break is used in conditionals and loops 
 * continue
 */
// 2 sets of emotions

// -> positive { happy, jumpy, excited }

//  negative  { Sad , Suicidal ,deepressed }

Console.WriteLine("How are you feeling today?");

string feeling= Console.ReadLine();

switch (feeling)
{
    case "happy":
        Console.WriteLine("Happy Quote");
        break;
    case "Sad":
        Console.WriteLine("Play a song");
        break;

    default:
        Console.WriteLine("Sad Puppy");
        break;
}