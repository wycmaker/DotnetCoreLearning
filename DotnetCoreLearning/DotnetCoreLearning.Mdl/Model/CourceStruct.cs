﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreLearning.Mdl.Model
{
    public struct CourceStruct
    {
        public long CourceId { get; set; }
        public string CourceSymbol { get; set; }
        public long CampusId { get; set; }
        public string Name { get; set; }
        public int CourceStatus { get; set; }
        public int SchoolGrade { get; set; }
        public int AcademicYear { get; set; }
        public int CourceCategory { get; set; }
        public int Grade { get; set; }
        public int CourceProperty { get; set; }
        public int CourceDate { get; set; }
        public long ClassroomId { get; set; }
        public TimeSpan CourceStartTime { get; set; }
        public TimeSpan CourceEndTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int CourceCount { get; set; }
        public decimal? CourcePrice { get; set; }
        public decimal Deposit { get; set; }
        public bool IsDiscount { get; set; }
        public decimal? CurrentStudentPrice { get; set; }
        public decimal? GroupPrice { get; set; }
        public decimal? CourceSalePrice { get; set; }
        public string Note { get; set; }
    }
}
