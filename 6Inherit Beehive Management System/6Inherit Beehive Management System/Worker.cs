using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6Inherit_Beehive_Management_System
{
    class Worker : Bee
    {
        private string[] jobsICanDO;
        private int shiftsToWork;
        private int shiftsWorked;

        public string CurrentJob { get; private set; }
        private int shiftsLeft;
        public override int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public Worker(string[] jobsICanDO, double weight) : base(weight)
        {
            this.jobsICanDO = jobsICanDO;
        }

        public bool DoThisJob(string jobToDo, int shiftsToWork)
        {
            if (!string.IsNullOrEmpty(this.CurrentJob))
                return false;
            foreach (string job in jobsICanDO)
            {
                if (jobToDo == job)
                {
                    this.CurrentJob = job;
                    this.shiftsToWork = shiftsToWork;
                    this.shiftsWorked = 0;
                    this.shiftsLeft = shiftsToWork;
                    return true;
                }
            }
            return false;
        }

        public bool WorkOneShift()
        {
            if (string.IsNullOrEmpty(this.CurrentJob))
                return false;
            this.shiftsWorked++;
            if (this.shiftsWorked > shiftsToWork)
            {
                this.CurrentJob = "";
                this.shiftsToWork = 0;
                this.shiftsWorked = 0;
                return true;
            }
            else
                return false;
        }
    }
}
