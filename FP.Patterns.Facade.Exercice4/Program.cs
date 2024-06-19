using FP.Patterns.Facade.Exercice4;

HomeEntertainmentFacade homeEntertainmentFacade = new HomeEntertainmentFacade();

homeEntertainmentFacade.WatchMovie();
Console.WriteLine("\n---------\n----------");
homeEntertainmentFacade.PlayGame();
Console.WriteLine("---------\n----------");
homeEntertainmentFacade.ListenMusic();