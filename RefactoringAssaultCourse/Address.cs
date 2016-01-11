using System;

namespace RefactoringAssaultCourse
{
    public class Address {
	
        private String house;
        private String street;
        private String city;
        private String postcode;
	
        public Address(String house, String street, String city, String postcode) {
            this.house = house;
            this.street = street;
            this.city = city;
            this.postcode = postcode;
        }
        public String GetHouse() {
            return house;
        }

        public String GetStreet() {
            return street;
        }

        public String GetCity() {
            return city;
        }

        public String GetPostcode() {
            return postcode;
        }
    }
}
