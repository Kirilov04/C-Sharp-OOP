using BorderControl.Models.Interfraces;

namespace BorderControl.Models
{
    public class Robot : BaseEntity
    {
        public string Id  { get; init; }

        public string Model { get; init; }

        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }
    }
}
