using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AssessorsUI
{
    public class PrintDocument
    {
        public int Id { get; set; }

        public string BookNoColorRevised { get; set; }

        public string TaxDeclarationNo { get; set; }

        public string Owner { get; set; }

        public string PropertyIdentificationNo { get; set; }

        public string SurveyNo { get; set; }

        public string AssessorLotNo { get; set; }

        public string DeclarationCancelsTDNo { get; set; }

        public PictureBox Image { get; set; }
    }
}
