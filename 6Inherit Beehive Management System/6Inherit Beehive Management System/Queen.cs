using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6Inherit_Beehive_Management_System
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers) : base(275)
        {
            this.workers = workers;
        }

        public bool AssiginWork(string jobToDo, int shiftsToWork)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(jobToDo, shiftsToWork))
                    return true;
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing '\r\n" + workers[i].CurrentJob +
                            "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
                else
                        report += "Worker #" + (i + 1) + " will be done with '\r\n" + workers[i].CurrentJob +
                            "' after this shift\r\n";
            }

            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                totalConsumption += workers[i].GetHoneyConsumption();
            }
            totalConsumption += this.GetHoneyConsumption();
            report += "Total honey consumption: " + totalConsumption + " units";

            return report;
        }

        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
            }
            consumption = largestWorkerConsumption;
            if (workersDoingJobs >= 3)
                consumption += 30;
            else
                consumption += 20;
            return consumption;
        }
    }
}
