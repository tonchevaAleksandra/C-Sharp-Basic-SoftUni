using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int patientsAccept = 0;
            int totalThreated = 0;
            int patientRejected = 0;
            int totalUnthreated = 0;

            for (int i = 1; i <= days; i++)
            {
                int totalPatients = int.Parse(Console.ReadLine());
                if (i % 3 != 0 || (i % 3 == 0 && totalUnthreated <= totalThreated))
                {
                    if (totalPatients > doctors)
                    {
                        patientsAccept = doctors;
                        patientRejected = totalPatients - doctors;
                        totalThreated += patientsAccept;
                        totalUnthreated += patientRejected;

                    }
                    else if (totalPatients == doctors)
                    {
                        patientsAccept = doctors;
                        patientRejected = 0;
                        totalThreated += patientsAccept;
                        totalUnthreated += patientRejected;
                    }
                    else
                    {
                        patientsAccept = totalPatients;
                        patientRejected = 0;
                        totalThreated += patientsAccept;
                        totalUnthreated += patientRejected;
                    }

                }

                if (i % 3 == 0 && totalUnthreated > totalThreated)
                {
                    doctors++;

                    if (totalPatients > doctors)
                    {
                        patientsAccept = doctors;
                        patientRejected = totalPatients - doctors;
                        totalThreated += patientsAccept;
                        totalUnthreated += patientRejected;
                    }
                    else if (totalPatients == doctors)
                    {
                        patientsAccept = doctors;
                        patientRejected = 0;
                        totalThreated += patientsAccept;
                        totalUnthreated += patientRejected;
                    }
                    else
                    {
                        patientsAccept = totalPatients;
                        patientRejected = 0;
                        totalThreated += patientsAccept;
                        totalUnthreated += patientRejected;
                    }

                }

            }

            Console.WriteLine($"Treated patients: {totalThreated}.");
            Console.WriteLine($"Untreated patients: {totalUnthreated}.");


        }
    }
}
