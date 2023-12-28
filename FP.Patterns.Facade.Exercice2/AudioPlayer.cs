namespace FP.Patterns.Facade.Exercice2
{
    public class AudioPlayer
    {
        public void PlayAudio()
        {
            Console.WriteLine("Audio played");
        }

        public void PauseAudio()
        {
            Console.WriteLine("Audio paused");
        }

        public void StopAudio()
        {
            Console.WriteLine("Audio stoped");
        }

        public void GetAudioInfo()
        {
            Console.WriteLine("This is an audio player");
        }
    }
}
