using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TASRDP.Models
{
    [Table("questions")]
    public sealed class Question
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        [Column("questionid")]
        public int QuestionId { get; set; }

        /// <summary>
        /// Опросник, связанный с этим вопросом
        /// </summary>
        [Column("surveyid")]
        [ForeignKey("surveys")]
        public int SurveyId { get; set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        [Column("text")]
        public string Text { get; set; }

        /// <summary>
        /// Можно ли выбрать несколько вариантов ответа
        /// </summary>
        [Column("ismultiple")]
        public bool IsMultiple { get; set; }

        public Survey Survey { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
