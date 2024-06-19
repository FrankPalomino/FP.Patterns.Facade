namespace FP.Patterns.Facade.Exercice4
{
    public class HomeEntertainmentFacade
    {
        private readonly Television _tv;
        private readonly StreamingService _streamingService;
        private readonly SoundSystem _soundSystem;
        private readonly GamingConsole _gamingConsole;

        public HomeEntertainmentFacade()
        {
            _tv = new Television();
            _streamingService = new StreamingService();
            _soundSystem = new SoundSystem();
            _gamingConsole = new GamingConsole();
        }

        public void WatchMovie()
        {
            _tv.TurnOn();
            _soundSystem.TurnOn();
            _streamingService.LogIn();
        }

        public void PlayGame()
        {
            _tv.TurnOn();
            _soundSystem.TurnOn();
            _gamingConsole.TurnOn();
        }

        public void ListenMusic()
        {
            _soundSystem.TurnOn();
            _streamingService.LogIn();
        }
    }
}
