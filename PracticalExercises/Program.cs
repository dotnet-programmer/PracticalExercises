using PracticalExercises;

Console.Title = "Practical exercises with solutions";
Console.ForegroundColor = ConsoleColor.Green;

Action[] solvedProblemsFunctions =
[
	FirstBook.FirstBookExercises,
	SecondBook.SecondBookExercises,
];

MainMenu.DoWork(solvedProblemsFunctions);