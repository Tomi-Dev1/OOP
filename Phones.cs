using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace OOPs_Illustration
{
    // Encapsulation
    public class Intern
    {
        private string name;
        private string gender;
        private DateTime createdAt;

        public Intern()
        {
            this.createdAt = DateTime.Now;
        }
        public DateTime GetCreationDate()
        {
            return this.createdAt;
        }
        public void SetName(string iname)
        {
            this.name = iname;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetGender(string igender)
        {
            if (igender == "Male" || igender == "Female")
            {
                this.gender = igender;
            }
            else
            {
                throw new Exception("Invalid gender");
            }
        }

        public string GetGender()
        {
            return this.gender;
        }
        public void DisplayInternDetails()
        {
            Console.WriteLine($"name = {name}, gender = {gender}");
        }
    }

    // Abstraction

    abstract class Intern2
    {
        public string Complexion { get; set; }

        public string Address { get; set; }
        public Intern2(string complexion, string address)
        {
            Complexion = complexion;
            Address = address;
        }
    }

    // Inheritance and polymorphism

    public class Intern3
    {
        public uint Salary { get; set; }
        public int CostofTransportation { get; set; }

        public bool badgein()
        {
            return true;
        }
        public bool badgeout()
        {
            return true;
        }

        public class Facilitator : Intern3
        {
            public bool FacilitateSessions()
            {
                return true;
            }
        }
    }

    // POLYMORPHISM
    public class Garage
    {
        public virtual void InPersonSessions()
        {
            Console.WriteLine("Garage Rampup");
        }
    }
    public class storageroom : Garage
        {
        public override void InPersonSessions()
        {
            Console.WriteLine("storageroom tools");
        }
    }
}











