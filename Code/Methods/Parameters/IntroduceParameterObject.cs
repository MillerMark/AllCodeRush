using System;

namespace AllCodeRush.Code.Methods.Parameters
{

  public class IntroduceParameterObject
	{
    public void Test()
		{
      Location start = GetCurrentLocation();
      Directions directions = GetDirections(start, "Acme Supply", "123 Main Street", "Gotham", "New York", "12345");
		}

    public Directions GetDirections(Location origin, string destinationName, string street, string city, string stateProvince, string postalCode)
		{
      //Location destination = GetLocation(street, city, stateProvince, postalCode);
      throw new NotImplementedException();
		}

    private Location GetCurrentLocation()
    {
      throw new NotImplementedException();
    }
	}
}
