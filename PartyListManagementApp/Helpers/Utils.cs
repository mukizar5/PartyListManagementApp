

using PartyAttendeesManagementApp.Enums;

namespace PartyAttendeesManagementApp.Helpers
{
    public static class Utils
    {
        public static List<Attendee> CreateAttendees()
        {
            List<Attendee> attendees = new()
        {
            new Attendee {Name="joram kobusingye", PartyFees=PartyFees.VVIP},
            new Attendee {Name= "amara pearl", PartyFees=PartyFees.VIP},
            new Attendee {Name= "eboku collins", PartyFees=PartyFees.Couples},
            new Attendee {Name= "paul mugume", PartyFees=PartyFees.Singles},
            new Attendee {Name= "solo arinitwe", PartyFees=PartyFees.Couples},
            new Attendee {Name= "akara martin", PartyFees=PartyFees.VIP},
            new Attendee {Name= "delirious echobu", PartyFees=PartyFees.Singles},
            new Attendee {Name= "amara denise", PartyFees=PartyFees.VVIP},
            new Attendee {Name= "gladys kibalama", PartyFees=PartyFees.VVIP},
            new Attendee {Name= "ivan kato", PartyFees=PartyFees.VVIP},
            new Attendee {Name= "sarah nantongo", PartyFees=PartyFees.VIP},
            new Attendee {Name= "peter ssempa", PartyFees=PartyFees.Couples},
            new Attendee {Name= "linda nabatanzi", PartyFees=PartyFees.Singles},
            new Attendee {Name= "isaac mukasa", PartyFees=PartyFees.Couples},
            new Attendee {Name= "ruth nakato", PartyFees=PartyFees.VIP},
            new Attendee {Name= "josephine kawuma", PartyFees=PartyFees.Singles},
            new Attendee {Name= "david lubega", PartyFees=PartyFees.VVIP},
            new Attendee {Name= "mercy nantale", PartyFees=PartyFees.VVIP},
            new Attendee {Name= "andrew kizito", PartyFees=PartyFees.VIP}
        };
           
            return attendees;

        }
        
        public static List<double> AssignPartyFee( List<Attendee> attendees)
        {
            List<double> partyFees = new();

            foreach (Attendee attendee in attendees)
            {
                switch (attendee.PartyFees)
                {
                    case PartyFees.VVIP:
                        partyFees.Add(1000000);
                        break;
                    case PartyFees.VIP:
                        partyFees.Add(500000);
                        break;
                    case PartyFees.Couples:
                        partyFees.Add(300000);
                        break;
                    case PartyFees.Singles:
                        partyFees.Add(10000);
                        break;
                    default:
                        continue;
                }
            }
            return partyFees;
        
        }
       
        public static double CalculateFees ( List<double> partyFees )
        {
            double fees = 0;

            foreach(double partyfee in partyFees)
            {
                fees += partyfee;

            }
            return fees;
        }

        public static void Display( double fees)
        {
            Console.WriteLine($" Total Fees: {fees.ToString("N0")}");
        }


    }
}
