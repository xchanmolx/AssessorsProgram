using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssessorsUI
{
    public class Document
    {
        public int Id { get; set; }

        public string Book_No_Color_Revised { get; set; }

        public string TD_No { get; set; }

        public string Owner { get; set; }

        public string Property_Identification_No { get; set; }

        public string Survey_No { get; set; }

        public string Assessors_Lot_No { get; set; }

        public string Declaration_Cancels_TD_No { get; set; }

        public Byte[] Img { get; set; }
    }
}
