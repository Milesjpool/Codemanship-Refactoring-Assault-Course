using NUnit.Framework;

namespace RefactoringAssaultCourse.Tests
{
    [TestFixture]
    public class VideoLibraryTests {

        [Test]
        public void VideosAddedToLibraryAreAvailableToRent() {
            VideoLibrary videoLibrary = new VideoLibrary();
            Video video = new Video("Jaws", Rating.Fifteen);
            videoLibrary.AddVideo(video);
            Assert.True(videoLibrary.HasVideo("Jaws"));
        }
	
        [Test]
        public void VideosNotAddedToLibraryAreAvailableToRent() {
            VideoLibrary videoLibrary = new VideoLibrary();
            Assert.False(videoLibrary.HasVideo("Jaws"));
        }
	
    }
}
