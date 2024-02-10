using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TASRDP.Models
{
    [Table("surveys")]
    public sealed class Survey
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        [Column("surveyid")]
        public int SurveyId { get; set; }

        /// <summary>
        /// Название опросника
        /// </summary>
        [Column("title")]
        public string Title { get; set; }

        /// <summary>
        /// Описание опросника
        /// </summary>
        [Column("description")]
        public string Description { get; set; }

        public List<Interview> Interviews { get; set; }
        public List<Question> Questions { get; set; }
    }
}
