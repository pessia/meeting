namespace PesiFirstApp.API.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int SenderId { get; set; }

        public User Sender { get; set; }

        public int RecipientId { get; set; }
        public User Recipient { get; set; }
        public string Content { get; set; }

    }
}