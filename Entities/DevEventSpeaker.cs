namespace AwesomeDevEvents.API.Entities
{
    public class DevEventSpeaker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TalkTitle { get; set; } 
        public string TalkDescription { get; set;}
        public string LinkedinProfile { get; set;}
        public Guid DevEventId { get; set; }
    }
}
