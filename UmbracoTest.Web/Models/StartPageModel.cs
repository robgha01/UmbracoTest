using BlueLeet.UCodeFirst;
using BlueLeet.UCodeFirst.ContentTypes;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;

namespace UmbracoTest.Web.Models
{
    [ContentType(DisplayName = "Sida: Start", Icon = Icon.Home, AllowAtRoot = true, Variations = ContentVariation.Culture, Description = "", PropertySortMode = PropertySortMode.LocalFirst)]
    public class StartPageModel : BaseContentModel
    {
        public StartPageModel(IPublishedContent content) : base(content)
        {
        }

        ///// <summary>
        ///// Gets or sets the main body.
        ///// </summary>
        //[Property(DataType.GridFrontPage, Tab.ModuleContent, DisplayName = "#GridStartPage name", Description = "#GridStartPage description")]
        //public virtual string GridStartPage { get; set; }
    }
}
