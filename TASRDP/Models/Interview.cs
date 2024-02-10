using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TASRDP.Models
{
    [Table("interviews")]
    public sealed class Interview
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        [Column("interviewid")]
        public int InterviewId { get; set; }

        /// <summary>
        /// Интервьюируемый
        /// </summary>
        [Column("interviewee")]
        public string Interviewee { get; set; }

        /// <summary>
        /// Опрос, по которому проводилось интервью
        /// </summary>
        [Column("surveyid")]
        public int SurveyId { get; set; }

        public List<Result> Results { get; set; }
    }
}
