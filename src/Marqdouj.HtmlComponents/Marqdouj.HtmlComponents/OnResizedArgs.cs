namespace Marqdouj.HtmlComponents
{
    public class OnResizedArgs(string id, double height, double width)
    {
        public string Id { get; } = id;
        public double Height { get; } = height;
        public double Width { get; } = width;
    }
}
