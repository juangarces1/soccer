using System;
using System.Collections.Generic;

namespace Soccer.Common.Models
{
    public class TournamentResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartDateLocal => StartDate.ToLocalTime();

        public DateTime EndDate { get; set; }

        public DateTime EndDateLocal => EndDate.ToLocalTime();

        public bool IsActive { get; set; }

        public string LogoPath { get; set; }

        //public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
        //    ? "https://soccerweb0.azurewebsites.net//images/noimage.png"
        //    : $"https://soccerweb0.azurewebsites.net{LogoPath.Substring(1)}";

        public string LogoFullPath { get; set; }

        public List<GroupResponse> Groups { get; set; }
    }
}
