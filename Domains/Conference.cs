namespace Diploma.Domains
{
    public class Conference
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int CountParticipants { get; set; }
    }
}
