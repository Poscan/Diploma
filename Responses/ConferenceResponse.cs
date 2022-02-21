namespace Diploma.Responses
{
    public class ConferenceResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int CountParticipants { get; set; }
        public ClientResponse Owner { get; set; }
    }
}
