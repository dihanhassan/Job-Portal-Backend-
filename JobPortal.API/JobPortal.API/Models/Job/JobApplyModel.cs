﻿namespace JobPortal.API.Models.Job
{
    public class JobApplyModel
    {
        public int PostID { get; set; }
        public string RecruiterID { get; set; }
        public string EmployeeID { get; set; }
        public DateTime AppliedDate { get; set; } = DateTime.Now;
    }
}
