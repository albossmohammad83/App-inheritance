using System;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() 
            {
                new XSClubPromotoer("Jon", "Jones", 654123459),
                new XSClubPromotoer("Jim", "Jones", 541234592),
                new OmniaClubPromoter("Jane", "Jones", 541234252)
            };
            foreach(var promote in promoters)
            {
                promote.Promote();
            }
            List<Writer> writers = new List<Writer>() 
            {
                new BookWriter("Jon", "Jones"),
                new BookWriter("Jim", "Jones"),
                new BlogWriter("Jane", "Jones")
            };
            foreach(var writer in writers)
            {
                writer.Write();
            }
             List<IBodyBuilder> bodybuilders = new List<IBodyBuilder>() 
            {
                new XSClubPromotoer("Jon", "Jones", 654123459),
                new XSClubPromotoer("Jim", "Jones", 541234592),
            };
            foreach(var bodybuilder in bodybuilders)
            {
                bodybuilder.Workout();
            }
             List<IVlogger> vlogers = new List<IVlogger>() 
            {
                new XSClubPromotoer("Jon", "Jones", 654123459),
                new BookWriter("Jim", "Jones"),
            };
            foreach(var vloger in vlogers)
            {
                vloger.Vlog();
            }
        }
    }
}