using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartyAttendeesManagementApp.Enums;
using PartyAttendeesManagementApp.Helpers;

namespace PartyAttendeesManagementApp
{
    public class Attendee:BaseClass
    {
        public string Name { get; set; }

        public PartyFees PartyFees { get; set; }


        
    }
}
