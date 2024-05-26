using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("701 E University Parkway", "Provo", "UT", 84604);
        Address address2 = new Address("1000 Business Lane", "New York City","NY", 10001);
        Address address3 = new Address("296 Murray Park Ave", "Murray", "UT", 84107);

        Lecture lecture = new Lecture
        (
            "BYU Commencement Speech", 
            "Come listen to an Apostle of the Lord speak to the graduating class of 2025.", 
            "4/26/2025", 
            "5:00PM", 
            address1, 
            "Jeffrey R Holland", 
            19000
        );
        Reception reception = new Reception
        (
            "Dylan & Ashlie's Wedding Reception", 
            "You have been invited to celebrate the union of Dylan Stephenson and Ashlie Johnson! We will have food, dancing, and lots of music. Come join us!", 
            "8/17/2021",
            "7:30PM",
            address2,
            "ashlie&dylan@gmail.com"
        );
        OutdoorGathering outdoorGathering = new OutdoorGathering
        (
            "Annual Stephenson Family Reunion",
            "Hello family! We have a great event planned for this year's family reunion. Come to Murray Park for a BBQ, many fun treats, blind auction, and pickleball!",
            "7/16/2024",
            "12:00PM",
            address3,
            "90° Sunny"
        );

        Console.WriteLine("--Standard Details for Lecture--");
        lecture.DisplayStandardDetails();
        Console.WriteLine("--Full Details For Lecture--");
        lecture.DisplayFullDetails();
        Console.WriteLine("--Short Details for Lecture--");
        lecture.DisplayShortDescription();

        Console.WriteLine("--Standard Details for Reception--");
        reception.DisplayStandardDetails();
        Console.WriteLine("--Full Details For Reception--");
        reception.DisplayFullDetails();
        Console.WriteLine("--Short Details for Reception--");
        reception.DisplayShortDescription();

        Console.WriteLine("--Standard Details for Outdoor Gathering--");
        outdoorGathering.DisplayStandardDetails();
        Console.WriteLine("--Full Details For Outdoor Gathering--");
        outdoorGathering.DisplayFullDetails();
        Console.WriteLine("--Short Details for Outdoor Gathering--");
        outdoorGathering.DisplayShortDescription();
    }
}