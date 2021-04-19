using CoronaTest.Core.Entities;
using CoronaTest.Core.Sets;
using System;

namespace CoronaTest.Web.DataTransferObjects
{
    public class ExaminationDto
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Participant { get; set; }
        public int ParticipantId { get; set; }
        public string Campaign { get; set; }
        public int CampaignId { get; set; }
        public string TestCenter { get; set; }
        public int TestCenterId { get; set; }
        public TestResults Result { get; set; }
        public DateTime ExaminationAt { get; set; }
        public ExaminationStates State { get; set; }

        public ExaminationDto(Core.DataTransferObjects.ExaminationDto _)
        {

        }

        public ExaminationDto(Examination examination)
        {
            Id = examination.Id;
            Identifier = examination.Identifier;
            Participant = $"{examination.Participant.Firstname} {examination.Participant.Lastname}";
            ParticipantId = examination.Participant.Id;
            Campaign = examination.Campaign.Name;
            CampaignId = examination.Campaign.Id;
            TestCenter = examination.TestCenter.Name;
            TestCenterId = examination.TestCenter.Id;
            Result = examination.TestResult;
            ExaminationAt = examination.ExaminationAt;
            State = examination.ExaminationState;
        }
    }
}
