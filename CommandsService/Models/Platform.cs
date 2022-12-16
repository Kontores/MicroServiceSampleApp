using System.ComponentModel.DataAnnotations;

namespace CommandsService.Models
{
    public record Platform
    {
        [Key]
        [Required]
        public int Id { get; init; }

        [Required]
        public int ExternalId { get; init; }

        [Required]
        public string Name { get; init; }
        public ICollection<Command> Commands { get; init; } = new List<Command>();
    }
}
