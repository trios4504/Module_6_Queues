using System;
using System.Collections.Generic;

namespace Module_6_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital myHospital = new Hospital();

            myHospital.AddPeopleIntoTheQueue("First Patient");
            myHospital.AddPeopleIntoTheQueue("Second Patient");
            myHospital.AddPeopleIntoTheQueue("Third Patient");
            myHospital.AddPeopleIntoTheQueue("Fourth Patient");
            myHospital.AddPeopleIntoTheQueue("Fifth Patient");
            myHospital.AddPeopleIntoTheQueue("Sixth Patient");

            myHospital.HowManyPatientsWaiting();
            myHospital.ShowMeTheActualPatients();
            myHospital.PatientAttended();

            myHospital.HowManyPatientsWaiting();
            myHospital.ShowMeTheActualPatients();
        }
    }

    public class Hospital
    {
        private Queue<string> waitingQueue = new Queue<string>();

        public void AddPeopleIntoTheQueue(string parameter)
        {
            waitingQueue.Enqueue(parameter);
        }

        public void HowManyPatientsWaiting()
        {
            Console.WriteLine("I have " + waitingQueue.Count + " patients waiting to be seen.");
        }

        public void ShowMeTheActualPatients()
        {
            foreach (var item in waitingQueue)
            {
                Console.WriteLine("Patient: " + item);
            }
        }

        public void PatientAttended()
        {
            waitingQueue.Dequeue();
        }


    }
}
