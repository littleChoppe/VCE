using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6Beehive_Management_System
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
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
                    if (workers[i].ShiftLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing '\r\n" + workers[i].CurrentJob +
                            "' for " + workers[i].ShiftLeft + " more shifts\r\n";
                else
                        report += "Worker #" + (i + 1) + " will be done with '\r\n" + workers[i].CurrentJob +
                            "' after this shift\r\n";
            }
            return report;
        }
    }
}
