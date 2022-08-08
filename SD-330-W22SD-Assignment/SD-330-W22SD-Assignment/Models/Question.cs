namespace SD_330_W22SD_Assignment.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string? UserId { get; set; }
        public SlackUser? SlackUser { get; set; }
        public HashSet<Answer> Answers { get; set; } =  new HashSet<Answer>();
    }
}
