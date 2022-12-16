using System.ComponentModel.DataAnnotations;

namespace CommandsService.Models
{
    public record Command
    {
        [Key]
        [Required]
        public int Id { get; init; }

        [Required]
        public string HowTo { get; init; }

        [Required]
        public string CommandLine { get; init; }

        [Required]
        public int PlatformId { get; init; }
        public Platform Platform { get; init; }
    }
}
