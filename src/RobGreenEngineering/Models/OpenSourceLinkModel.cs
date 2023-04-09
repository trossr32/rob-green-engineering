namespace RobGreenEngineering.Models;

public interface IOpenSourceLink
{
    public OpenSourceLinkType LinkType { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Image { get; set; }
}

public class OpenSourceLink
{
    public OpenSourceLinkType LinkType { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Image { get; set; }
}

public class GithubOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public GithubOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.Github;
        Name = "github";
        Image = "github-icon";
        Url = url;
    }
}

public class ChromeOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public ChromeOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.Chrome;
        Name = "chrome";
        Image = "chrome-icon";
        Url = url;
    }
}

public class EdgeOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public EdgeOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.Edge;
        Name = "edge";
        Image = "edge-logo";
        Url = url;
    }
}

public class FirefoxOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public FirefoxOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.Firefox;
        Name = "firefox";
        Image = "firefox-logo";
        Url = url;
    }
}

public class PowershellGalleryOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public PowershellGalleryOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.Github;
        Name = "powershell gallery";
        Image = "powershell-icon";
        Url = url;
    }
}

public class OpenSourceModel
{
    public OpenSourceType OpenSourceType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public List<IOpenSourceLink> Links { get; set; }
}

public class OpenSourceLinkModel
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Image { get; set; }
}

public enum OpenSourceType
{
    BrowserExtension,
    PowershellModule
}

public enum OpenSourceLinkType
{
    Github,
    Chrome,
    Edge,
    Firefox,
    PowershellGallery
}