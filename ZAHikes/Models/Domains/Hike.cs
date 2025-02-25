﻿namespace ZAHikes.Models.Domains
{
    public class Hike
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? HikeImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid ProvinceId { get; set; }

        //Navigation Property

        public Difficulty Difficulty { get; set; }
        public Province Province { get; set; }
    }
}
