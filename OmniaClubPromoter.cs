public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void SharedWithInnerCircle()
    {
        System.Console.WriteLine("I share with my friends");
    }

    protected override void UsePaidAds()
    {
         System.Console.WriteLine("I use Google Adwords.");
    }
}