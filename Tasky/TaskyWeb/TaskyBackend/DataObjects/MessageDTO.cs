namespace TaskyBackend.DataObjects
{
    public class MessageDTO
    {
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }

        public string Content { get; set; }
        public bool IsSent { get; set; }
    }
}
