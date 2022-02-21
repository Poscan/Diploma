namespace Diploma.Requests
{
    public class ConferenceRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int CountParticipants { get; set; }
        public ClientRequest Owner { get; set; }
    }
}
