using System.Collections.Generic;

// to do list
// add console.clear usage needed por favor

List<string> tasks = new List<string>();

Console.WriteLine("How many tasks do you want to complete?");


int taskNum = Convert.ToInt32(Console.ReadLine());
Console.Clear();
for (int i = 0; i < taskNum; i++) 
{
    Console.Write("Enter task:");
    var listInput = Console.ReadLine();
    tasks.Add(listInput);
}

Console.Clear();

int counter = 1;
for (int i = 0; i < taskNum; i++)
{
    Console.WriteLine(counter + ". " +tasks[i]);
    counter++;

}

while (taskNum > 0)
{
    Console.Write("Enter the number of the task you are done with when you are done with it:");
    int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
    tasks.RemoveAt(taskNumber);
    taskNum--;
    Console.Clear();
    int counter2 = 1;
    for (int b = 0; b < taskNum; b++)
    {
        Console.WriteLine(counter2 + ". " + tasks[b]);
        counter2++;
    }
}

if (taskNum <= 0)
{
    Console.WriteLine("Congrats you finished all your tasks!");
}

Console.ReadKey();
