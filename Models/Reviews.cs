using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Review.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewsId { get; set; }
        public Guid SecretKey { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Employee mail")]
        public string EmployeeEmail { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Reviewer mail")]
        public string ReviewerEmail { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int Technical_EmployeeRating { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string Technical_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int Technical_ReviewerRating { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string Technical_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int Communication_EmployeeRating { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string Communication_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int Communication_ReviewerRating { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string Communication_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int InternationalLeadership_EmployeeRating { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string InternationalLeadership_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int InternationalLeadership_ReviewerRating { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string InternationalLeadership_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int OrganizationalProcedures_EmployeeRating { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string OrganizationalProcedures_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int OrganizationalProcedures_ReviewerRating { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string OrganizationalProcedures_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int CommitmentObjectives_EmployeeRating { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string CommitmentObjectives_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please select this field")]
        public int CommitmentObjectives_ReviewerRating { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string CommitmentObjectives_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string AchievementsOnGoalsLastYear_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string AchievementsOnGoalsLastYear_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string EmployeeStrengths_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string EmployeeStrengths_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string AreasImprovement_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string AreasImprovement_ReviewerExplanation { get; set; }

        [Required]
        public string JIRAReportLink { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string ThisYearGoals_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string ThisYearGoals_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string AdditionalComments_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string AdditionalComments_ReviewerExplanation { get; set; }

        [Required(ErrorMessage = "Please select promotion field")]
        public bool ConsiderForPromotion { get; set; }

        [Required(ErrorMessage = "Please enter Employee explaination")]
        public string Promotion_EmployeeExplanation { get; set; }

        [Required(ErrorMessage = "Please enter Reviewer explaination")]
        public string Promotion_ReviewerExplanation { get; set; }

    }
}
