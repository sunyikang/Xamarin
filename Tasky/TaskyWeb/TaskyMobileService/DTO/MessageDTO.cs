namespace TaskyMobileService.DTO
{
    public class MessageDTO
    {
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public int Order { get; set; }
    }
}
