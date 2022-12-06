# bigvvill.CodeReviews.Console.ExerciseTracker

This is an application where you should record exercise data.

You should choose one type of exercise only. We want to keep the app simple so you focus on the subject you're learning and not on the business complexities.

You can choose raw SQL or Entity Framework for your data-persistence.

The model for your exercise class should have at least the following properties: {Id INT, DateStart DateTime, DateEnd DateTime, Duration TimeSpan, Comments string}

Your application should have the following classes: UserInput, ExerciseController, ExerciseService (where business logic will be handled) and ExerciseRepository.

You can choose between SQLite or SQLServer.

You need to use dependency injection to access the repository from the controller.
