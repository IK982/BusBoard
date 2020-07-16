using System.Collections.Generic;

namespace Bus_Board
{
    public class BusDepartureResponse
    //going to try and map the object in tranportapi.com.
    {
        public string Name { get; set; }
        public Departures Departures { get; set; }
        //  public MyNestedClass MyNestedObject { get; set; } follows this layout

    }

    public class Departures
    {
        public List<DepartureInfo> All { get; set; }
    }

    public class DepartureInfo
    {
        public string Line { get; set; }
        public string Direction { get; set; }
        public string ExpectedDepartureTime { get; set; }
    }
}


// public class MyNestedClass
// {
//     public int MyParam { get; set; }
// }