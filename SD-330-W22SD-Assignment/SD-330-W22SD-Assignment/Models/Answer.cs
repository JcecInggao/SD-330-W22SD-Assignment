namespace SD_330_W22SD_Assignment.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string UserId { get; set; }
        public SlackUser User { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }

    }
}
