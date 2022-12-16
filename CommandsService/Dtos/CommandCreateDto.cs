namespace CommandsService.Dtos
{
    public record CommandCreateDto
    {
        public string HowTo { get; init; }
        public string CommandLine { get; init; }
    }
}
