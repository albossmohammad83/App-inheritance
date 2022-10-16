public class XSClubPromotoer : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromotoer(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void SharedWithInnerCircle()
    {
        System.Console.WriteLine("I share with my instagram followers.");
    }

    protected override void UsePaidAds()
    {
         System.Console.WriteLine("I use facebook ads.");
    }

     public void Vlog()
    {
        System.Console.WriteLine("I use a DSLR in order to vlog.");
    }

    public void Workout()
    {
        System.Console.WriteLine("I workout at my house.");
    }
}