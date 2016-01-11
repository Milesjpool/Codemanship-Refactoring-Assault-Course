using System;
using System.Collections.Generic;

namespace RefactoringAssaultCourse
{
    public class Customer {
	
        private List<Video> rentals = new List<Video>();
        private Address address;
        private String dateOfBirth;
        private String name;


        public Customer(String name, Address address, String dateOfBirth) {
            this.name = name;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
        }

        public String GetDateOfBirth() {
            return dateOfBirth;
        }
	
        public List<Video> GetRentedVideos() {
            return rentals;
        }

        public void AddRental(Video video) {
            rentals.Add(video);
        }

        public String GetSummary() {
            return name + ", " + address.GetHouse() + " " + address.GetStreet() + ", " 
                   + address.GetCity() + ", " + address.GetPostcode();
        }

    }
}
