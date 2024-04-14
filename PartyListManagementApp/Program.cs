using PartyAttendeesManagementApp.Helpers;

var attendees = Utils.CreateAttendees();

var partyFee = Utils.AssignPartyFee(attendees);

var fees = Utils.CalculateFees(partyFee);

Utils.Display(fees);
