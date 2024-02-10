using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TASRDP.Models
{
    [Table("answers")]
    public sealed class Answer
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        [Column("answerid")]
        public int AnswerId { get; set; }

        /// <summary>
        /// Вопрос, относящийся к этому варианту ответа
        /// </summary>
        [Column("questionid")]
        [ForeignKey("questions")]
        public int QuestionId { get; set; }

        /// <summary>
        /// Текст варианта ответа
        /// </summary>
        [Column("text")]
        public string Text { get; set; }

        public Question Question { get; set; }
    }
}
