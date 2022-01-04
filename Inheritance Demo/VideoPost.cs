using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    //Add a deriving Class "VideoPost" with a property VideoURL and Length

    //Create required constructors to create a VideoPost
    //Adjust the ToString() method accordingly
    //create an instance of VideoPost

    //More advanced - use Timer and a Callback method here
    //create required fields
    //add member methods "Play" which should write the current duration of the video
    //and "Stop" which should stop the "timer" and write "Stopped at {0}s" onto the console.
    //Play the video after creating the instance and pause it when the user presses any key.

    /// <summary>
    /// 
    /// </summary>
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;

        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            ID = GetNextID();
            VideoURL = videoURL;
            Length = length;
            Title = title;
            IsPublic = isPublic;
            SendByUsername = sendByUsername;
        }
        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic, bool autoPlay)
        {
            ID = GetNextID();
            VideoURL = videoURL;
            Length = length;
            Title = title;
            IsPublic = isPublic;
            SendByUsername = sendByUsername;
            if (autoPlay)
            {
                Play();
            }
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
            }
            else
            {
                Stop();
            }
        }

        public void Play()
        {
            if (!isPlaying) {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(new TimerCallback(TimerCallback), null, 0, 1000);
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine("Video stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
                isPlaying = false;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}: {2} - by {3}", this.ID, this.Title, this.VideoURL, this.SendByUsername);
        }
    }
}
