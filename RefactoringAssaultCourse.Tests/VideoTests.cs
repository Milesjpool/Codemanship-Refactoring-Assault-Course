using NUnit.Framework;

namespace RefactoringAssaultCourse.Tests
{
    [TestFixture]
    public class VideoTests {
	
        [Test]
        public void CustomerMustBeOverTwelveToRentAVideoRatedTwelve() {
            Customer customer = new Customer(null, null, "2015-01-01");
            Video video = new Video(null, Rating.Twelve);
            Assert.Throws<CustomerUnderageException>(() => video.RentFor(customer));
        }
	
        [Test]
        public void VideoRentedByCustomerOfLegalAgeIsAddedToCustomersRentedVideos() {
            Customer customer = new Customer(null, null, "1964-01-01");
            Video video = new Video(null, Rating.Twelve);
            video.RentFor(customer);
            Assert.True(customer.GetRentedVideos().Contains(video));
        }

    }
}
