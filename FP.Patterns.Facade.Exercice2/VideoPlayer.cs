namespace FP.Patterns.Facade.Exercice2
{
    public class VideoPlayer
    {
        public void PlayVideo()
        {
            Console.WriteLine("Video played");
        }

        public void PauseVideo()
        {
            Console.WriteLine("Video paused");
        }

        public void StopVideo()
        {
            Console.WriteLine("Video stoped");
        }

        public void GetVideoInfo()
        {
            Console.WriteLine("This is an video player");
        }
    }
}
