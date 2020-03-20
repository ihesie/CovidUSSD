using System;

namespace CovidUSSD.Entities
{
    public class MenuItem
    {
        public Guid ID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int MenuNumber { get; set; }

        public int Level { get; set; }
    }
}
