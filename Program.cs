

using OOPs_Illustration;
using System;

public class Program
{
    static void Main()
    {
        Intern i = new Intern();
        i.SetName("Simi");
        i.SetGender("Female");
        Console.WriteLine($"Created at : {i.GetCreationDate()}");
        i.DisplayInternDetails();
    }
}

internal class Intern3
{
    public static bool badgein()
    {
        return true;
    }

    public static bool badgeout()
    {
        return true;
    }

    public class Facilitator
    {
        public static bool badgein()
        {
            return true;
        }
    }

    static void Main()
    {
        bool isBadgeInSuccessful = Intern3.badgein();

        Intern3.Facilitator facilitator = new Intern3.Facilitator();
        bool isFacilitatorBadgeInSuccessful = Intern3.Facilitator.badgein();
    }
}

internal class Program3 
{
     static void Main(string[] args)
    {
        storageroom T = new storageroom();
        T.InPersonSessions();
        Console.ReadLine();

    }
}




