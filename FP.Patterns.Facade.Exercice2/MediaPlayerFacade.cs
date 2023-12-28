namespace FP.Patterns.Facade.Exercice2
{
    public class MediaPlayerFacade
    {
        private readonly AudioPlayer _audioPlayer;
        private readonly VideoPlayer _videoPlayer;

        public MediaPlayerFacade()
        {
            _audioPlayer = new AudioPlayer();
            _videoPlayer = new VideoPlayer();
        }
        public void PlayMedia()
        {
            _audioPlayer.PlayAudio();
            _videoPlayer.PlayVideo();
        }

        public void PauseMedia()
        {
            _audioPlayer.PauseAudio();
            _videoPlayer.PauseVideo();
        }

        public void StopMedia()
        {
            _audioPlayer.StopAudio();
            _videoPlayer.StopVideo();
        }

        public void GetMediaInfo()
        {
            _audioPlayer.GetAudioInfo();
            _videoPlayer.GetVideoInfo();
        }
    }
}
