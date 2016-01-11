
using NUnit.Framework;

namespace RefactoringAssaultCourse.Tests
{
    [TestFixture]
    public class CustomerTests {
	
        [Test]
        public void CustomerSummaryIncludesFullNameAndAddress() {
            Address address = new Address("15", "High Street", "London", "WC1 2XX");
            Customer customer = new Customer("Mr T Bidley", address, "1971-01-01");
            Assert.That("Mr T Bidley, 15 High Street, London, WC1 2XX", Is.EqualTo(customer.GetSummary()));
        }

    }
}
