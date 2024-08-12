namespace DemoBlazerWebComponent.Global_state
{
    public class MessageState
    {
        public string? Message { get; set; }
        public string? Message2 { get; set; }

        public void SetMessage(string message)
        {
            Message2 = message;
        }
        public void CleanMessage()
        {
            Message2 = null;
        }
    }
}
