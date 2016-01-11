using System;

namespace RefactoringAssaultCourse
{
    public class Video
    {

        private String title;
        private Rating rating;


        public Video(String title, Rating rating)
        {
            this.title = title;
            this.rating = rating;
        }

        public Rating GetRating()
        {
            return rating;
        }

        public String GetTitle()
        {
            return title;
        }

        public void RentFor(Customer customer)
        {
            if (IsUnderAge(customer))
                throw new CustomerUnderageException();
            customer.AddRental(this);
        }

        private bool IsUnderAge(Customer customer)
        {

            try
            {
                // calculate customer's age in years and months

                // parse customer date of birth
                var calDateOfBirth = DateTime.Parse(customer.GetDateOfBirth());

                // get current date
                var calNow = DateTime.Now;

                // calculate age different in years and months
                int ageYr = (calNow.Year - calDateOfBirth.Year);
                int ageMo = (calNow.Month - calDateOfBirth.Month);

                // decrement age in years if month difference is negative
                if (ageMo < 0)
                {
                    ageYr--;
                }
                int age = ageYr;

                // determine if customer is under legal age for rating
                switch (rating)
                {
                    case Rating.Twelve:
                        return age < 12;
                    case Rating.Fifteen:
                        return age < 15;
                    case Rating.Eighteen:
                        return age < 18;
                    default:
                        return false;
                }

            }
            catch (FormatException e)
            {
                Console.Write(e.StackTrace);
            }
            return false;

        }

    }
}
