using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker
{
    public class StageNode
    {
        private string stageName;
        private StageNode next;

      public  StageNode(string stageName)
        {
            this.stageName = stageName;
        }
        public string StageName
        {
            get
            {
                return stageName;
            }
            set
            {
                stageName = value;
            }
        }

        public StageNode Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
}
