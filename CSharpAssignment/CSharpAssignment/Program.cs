// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using CSharpAssignment;

//Variables
int correctCounter = 0;
int incorrectCounter = 0;
string name = "";
double percentage=0;


//User enters name
Console.WriteLine("Please enter your name");
name = Console.ReadLine();

List<Questions> source = new List<Questions>();  
  
using (StreamReader r = new StreamReader("/Users/michaelfrancke/RiderProjects/CSharpAssignment/CSharpAssignment/Questions.json"))  
{  
    string json = r.ReadToEnd();  
    source = JsonSerializer.Deserialize<List<Questions>>(json);

    //Console.WriteLine(source[0].question);
    
    foreach (Questions question in source)
    {
                
        Console.WriteLine(question.question);
        for (int i = 0; i < question.answers.Length; i++)
        {
            Console.WriteLine(i + " )" + question.answers[i]);
        }
        string uAnswer = Console.ReadLine();
        if (int.Parse(uAnswer) == question.correctIndex - 1)
        {
            correctCounter++;
            Console.WriteLine("Correct!");
        }
        else
        {
            incorrectCounter++;
            Console.WriteLine("incorrect!");
        }
        
         

    }
    Console.WriteLine(percentage);
    percentage = correctCounter*(0.1);
    Console.WriteLine(percentage);
    
    //Printing out answer
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("|    Name    | Total correct answers | Total incorrect answers |   Percentage");
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("|        "+ name + "    |       " + correctCounter +"               |       " + incorrectCounter + "                 |          " + percentage*100);
    Console.WriteLine("--------------------------------------------------------");
} 