public interface IXmlContentService
{
    string GetXmlContent();
}

public class XmlContentService : IXmlContentService
{
    public string GetXmlContent()
    {
        // Your logic to generate or retrieve XML content
        return "<xml><data>Hello, XML!</data></xml>";
    }
}
