namespace MyServer.Model
{
    public class MyProgram
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string FilePath { get; set; }
        public string? Argument { get; set; }
    }
}
