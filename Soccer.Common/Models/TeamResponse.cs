namespace Soccer.Common.Models
{
    public class TeamResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LogoPath { get; set; }

        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
          ? "https://soccerweb0.azurewebsites.net//images/noimage.png"
          : $"https://soccerweb0.azurewebsites.net{LogoPath.Substring(1)}";
    }
}
