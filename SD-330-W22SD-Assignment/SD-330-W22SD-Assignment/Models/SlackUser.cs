using Microsoft.AspNetCore.Identity;

namespace SD_330_W22SD_Assignment.Models
{
    public class SlackUser : IdentityUser
    {
        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public SlackUser(): base()
        {
            Questions = new HashSet<Question>();

        }
    }
}
