﻿namespace CLINICAL.Application.Dtos.TakeExam.response
{
    public class GetAllTakeExamResponseDto
    {
        public int TakeExamId { get; set; }
        public string? Patient { get; set; }
        public string? Medic { get; set; }
        public string? StateTakeExam { get; set; }
        public DateTime AuditCreateDate { get;}
    }
}
