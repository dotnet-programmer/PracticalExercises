using PracticalExercises;

Console.Title = "Practical exercises with solutions";
Console.ForegroundColor = ConsoleColor.Green;

Action[] solvedProblemsFunctions = new[]
{
	FirstBook.FirstBookExercises,
	SecondBook.SecondBookExercises,
};

MainMenu.DoWork(solvedProblemsFunctions);