using System;

namespace DatingApp.API.Dtos
{
    public class PhotoForDetaileDto
    {
        public int id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}