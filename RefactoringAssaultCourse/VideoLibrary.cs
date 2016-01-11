using System;
using System.Collections.Generic;

namespace RefactoringAssaultCourse
{
    public class VideoLibrary 
    {
        private readonly Dictionary<String, Video> _videos = new Dictionary<String, Video>();

        public bool HasVideo(String title) {
            return _videos.ContainsKey(title);
        }

        public void AddVideo(Video video) {
            _videos.Add(video.GetTitle(), video);
        }

        private Dictionary<String, Video> GetVideos()
        {
            return _videos;
        } 
    }
}
