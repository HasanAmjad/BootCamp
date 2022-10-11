using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_TechLift_Candidate
{
    class TechLiftCandidate
    {
        public string name;
        public string CNIC;
        public string city;
        public double CGPA;
        public long project1Marks;
        public long project2Marks;

        public TechLiftCandidate(string getName, string getCNIC, string getCity, double getCGPA, long getmarks1, long getmarks2)
        {
            name = getName;
            CNIC = getCNIC; 
            city= getCity;
            CGPA = getCGPA;
            project1Marks = getmarks1;
            project2Marks =getmarks2;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {   
            List<TechLiftCandidate> CandidatesList = new List<TechLiftCandidate>();
            CandidatesList.Add(new TechLiftCandidate("Hasan Amjad", "35201-1455635-1", "Lahore", 3.36, 55, 100));
            CandidatesList.Add(new TechLiftCandidate("Ali ", "32201-1425635-1", "Pindi", 3.6, 55, 10));
            CandidatesList.Add(new TechLiftCandidate("Touseef ", "35231-1455635-1", "Quetta", 3.68, 55, 70));
            CandidatesList.Add(new TechLiftCandidate("Gohar ", "35201-1455635-1", "Lahore", 3.9, 55, 60));
            CandidatesList.Add(new TechLiftCandidate("Akbar ", "35201-1424635-1", "Sialkot", 3.06, 55, 30));
            CandidatesList.Add(new TechLiftCandidate("Me ", "35101-1455235-1", "Gujranwala", 3.12, 55, 30));
            CandidatesList.Add(new TechLiftCandidate("John ", "31101-1455635-1", "Lahore", 3.16, 55, 90));
            CandidatesList.Add(new TechLiftCandidate("Amjad", "35201-14533635-1", "Islamabad", 3.11, 55, 80));
            CandidatesList.Add(new TechLiftCandidate("Abdullah ", "3522-1455635-1", "Lahore", 3.22, 55, 70));

            foreach (var TechLiftCandidate in CandidatesList)
            {
                Console.WriteLine("TechLiftCandidate: {0},{1},{2},{3},{4}", TechLiftCandidate.name, TechLiftCandidate.CNIC, TechLiftCandidate.city, TechLiftCandidate.CGPA, TechLiftCandidate.project1Marks); ;
            }
            for (int i = 0; i < CandidatesList.Count; i++)
                if (CandidatesList(name[i])>3.5)
                { 
                }

                Console.ReadLine();
        }
       
           
    }
}
