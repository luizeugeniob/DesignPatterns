namespace DesignPatterns
{
    public class Request
    {
        public Format Format { get; private set; }

        public Request(Format format)
        {
            Format = format;
        }
    }

    public enum Format
    {
        XML,
        CSV,
        PERCENT
    }
}
