using System;
using AllCodeRush.Code.Conditionals.Support;

namespace AllCodeRush.Code.Conditionals
{
  public class FlattenConditional
  {
    public static bool AnyTrue(bool a, bool b, bool c)
    {
      if (a || b || c)
        return true;
      else
        return false;
    }

    public static void RentMovie(bool parentalControls, int minAgeForThisMovie, Guid movieID, Customer customer)
    {
      if (!parentalControls || customer.Age > minAgeForThisMovie)
        if (!RentalFacility.IsDown())
          if (RentalFacility.HasMovie(movieID))
            if (RentalFacility.CustomerHasValidPaymentDetails(customer))
            {
              RentalFacility.ReserveMovie(movieID);
              customer.Charge(RentalFacility.GetMoviePrice(movieID));
              customer.RentMovie(RentalFacility.GetMovie(movieID), TimeSpan.FromHours(48));
            }
    }
  }
}
