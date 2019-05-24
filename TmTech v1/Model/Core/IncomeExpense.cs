using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class IncomeExpense:CoreEntry
    {
        public IncomeExpense()
        {
            NoteProjectDetail = new NoteProjectDetail();
            Department = new Department();
            Staff = new Staff();
            Project = new Project();
            PurposeSuggestion = new PurposeSuggestion();
        }
        public int IncomeExpenseId { get; set; }
        public string IncomeExpenseCode { get; set; }
        public string No { get; set; }
        public string BillNo { get; set; }
        public int? DepartmentId { get; set; }
        public int? StaffId { get; set; }
        public decimal? MoneyIn { get; set; }
        public decimal? MoneyOut { get; set; }
        public decimal? MoneyUse { get; set; }
        public decimal? MoneyBack { get; set; }
        public decimal? RegisterValue { get; set; }
        public string Sign { get; set; }
        public string Content { get; set; }
        public decimal? Value { get; set; }
        public int? NoteId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int? ProjectId { get; set; }
        public int? ApproveStatusId { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveBy { get; set; }
        public int? PurposeSuggestionId { get; set; }



        public virtual Project Project { get; set; }
        public virtual NoteProjectDetail NoteProjectDetail { get; set; }
        public virtual Department Department { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual PurposeSuggestion PurposeSuggestion { get; set; }
    }

    public class IncomeExpenseMapper: ClassMapper<IncomeExpense>
    {
        public IncomeExpenseMapper()
        {
            Table("IncomeExpense");
            Map(p => p.NoteProjectDetail).Ignore();
            Map(p => p.Department).Ignore();
            Map(p => p.Staff).Ignore();
            Map(p => p.Project).Ignore();
            Map(p => p.PurposeSuggestion).Ignore();
            AutoMap();
        }
    }
}
