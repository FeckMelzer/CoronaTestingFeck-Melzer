using CoronaTest.Core.Sets;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaTest.Core.Entities
{
    public class Examination : EntityObject
    {
        public Campaign Campaign { get; set; }
        public Participant Participant { get; set; }
        public TestCenter TestCenter { get; set; }
        public TestResults TestResult { get; set; }
        public ExaminationStates ExaminationState { get; set; }
        public DateTime ExaminationAt { get; set; }
        public string Identifier { get; set; }

        public static Examination CreateNex()
        {
            return new Examination();
        }
        public string GetReservationText()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"CoronaTest - Identifier: {Identifier} ");
            sb.Append($"für Ihren Termin am {ExaminationAt.ToShortDateString()} ");
            sb.Append($"um {ExaminationAt.ToShortTimeString()} ");
            sb.Append($"im TestCenter: {TestCenter?.Name}!");

            return sb.ToString();
        }

        public string GetCancelText()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Storno - Identifier: {Identifier} ");
            sb.Append($"Ihr Termin am {ExaminationAt.ToShortDateString()} ");
            sb.Append($"um {ExaminationAt.ToShortTimeString()} ");
            sb.Append($"im TestCenter: {TestCenter?.Name} wurde storniert!");

            return sb.ToString();
        }
    }
}
