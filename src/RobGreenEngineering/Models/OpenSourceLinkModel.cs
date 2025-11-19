namespace RobGreenEngineering.Models;

public interface IOpenSourceLink
{
    public OpenSourceLinkType LinkType { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
}

public class OpenSourceLink
{
    public OpenSourceLinkType LinkType { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
}

public class GithubRepoOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public GithubRepoOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.GithubRepo;
        Name = "github";
        Image = "github-icon";
        Url = url;
        Title = "View this repository on github";
    }
}

public class GithubMarketplaceOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public GithubMarketplaceOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.GithubMarketplace;
        Name = "github marketplace";
        Image = "github-marketplace-icon";
        Url = url;
        Title = "View this action on github marketplace";
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
        Title = "Extension in the Chrome Web Store";
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
        Title = "Extension in the Microsoft Edge Add-ons store";
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
        Title = "Extension in the Firefox Add-ons store";
    }
}

public class PowershellGalleryOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public PowershellGalleryOpenSourceLink(string url)
    {
        LinkType = OpenSourceLinkType.PowershellGallery;
        Name = "powershell gallery";
        Image = "powershell-icon";
        Url = url;
        Title = "View in the Powershell Gallery";
    }
}

public class WebOpenSourceLink : OpenSourceLink, IOpenSourceLink
{
    public WebOpenSourceLink(string url, string image)
    {
        LinkType = OpenSourceLinkType.WebLink;
        Name = Title = Url = url;
        Image = image;
    }
}

public class OpenSourceModel
{
    public OpenSourceType OpenSourceType { get; set; }
    public string Name { get; init; }
    public string Description { get; init; }

    public List<IOpenSourceLink> Links { get; init; }
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
    PowershellModule,
    GithubAction
}

public enum OpenSourceLinkType
{
    GithubRepo,
    GithubMarketplace,
    Chrome,
    Edge,
    Firefox,
    PowershellGallery,
    WebLink
}