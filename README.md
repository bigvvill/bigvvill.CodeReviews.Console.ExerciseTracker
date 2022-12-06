# bigvvill.CodeReviews.Console.ExerciseTracker

This is an application where you should record exercise data.

You should choose one type of exercise only. We want to keep the app simple so you focus on the subject you're learning and not on the business complexities.

You can choose raw SQL or Entity Framework for your data-persistence.

The model for your exercise class should have at least the following properties: {Id INT, DateStart DateTime, DateEnd DateTime, Duration TimeSpan, Comments string}

Your application should have the following classes: UserInput, ExerciseController, ExerciseService (where business logic will be handled) and ExerciseRepository.

You can choose between SQLite or SQLServer.

You need to use dependency injection to access the repository from the controller.

Tips
Don't forget to add validation to your app. Besides the same validation you used in previous apps, you'll also need to make sure users only add phone-numbers with the correct format (specified by you).

Don't forget to create a Github repository for your project from the beginning.

You might come across the concept of Unit of Work in some tutorials. I suggest you don't use it, so you focus on learning how a single repository works.

Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern.

If you want to expand on your knowledge so far, create an application with two types of exercises (ex. weights and cardio), using EF for one and Raw SQL for the other.

Challenges
To illustrate the separation provided by the repository pattern, create a different branch of your project where you'll replace Entity Framework by Dapper or ADO.NET in your repository. You'll notice that you won't need to touch your controller.

Create an application with two types of exercises (ex. weights and cardio), using EF for one and Raw SQL for the other
