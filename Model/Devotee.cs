using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace AMS.Model
{
    public class Devotee
    {
        public string Name
        {
            get;
            set;
        }

        public Address Address
        {
            get;set;
        }

        public string MobileNumber
        {
            get;
            set;
        }

        public MemoryStream Picture
        {
            get;
            set;
        }

        public int AshrayGroup
        {
            get;
            set;
        }

    }
}
