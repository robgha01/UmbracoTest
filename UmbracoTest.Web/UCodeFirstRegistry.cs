using BlueLeet.UCodeFirst;
using BlueLeet.UCodeFirst.Structure;
using UmbracoTest.Web.Models;

namespace UmbracoTest.Web
{
    public class UCodeFirstRegistry : Registry
    {
        public UCodeFirstRegistry()
        {
            //ConfigureGrids();

            ForContentType<BaseContentModel>().ConfigureProperty(
                    model => model.GridFrontPage,
                    expression => expression.Inheritance(false).Searchable(x => x.Boost(5)))
                .ConfigureProperty(model => model.HideInNavigation, expression => expression.MarkAs(SystemPropertyType.NaviHide).WithKeys().Value("inverse", "1"))
                .ConfigureProperty(model => model.UmbracoUrlAlias, expression => expression.MarkAs(SystemPropertyType.UrlAlias))
                .ConfigureProperty(model => model.UmbracoUrlName, expression => expression.MarkAs(SystemPropertyType.UrlName))
                .ConfigureProperty(model => model.Redirect, expression => expression.WithKeys().Value("maxChars", 50));
        }

        private void ConfigureGrids()
        {
            ForContentType<BaseContentModel>().ConfigureProperty(
                model => model.GridFrontPage,
                expression => expression.Grid(
                    grid =>
                    {
                        grid.Layout("1 column layout", layout => layout.Section(12));
                        grid.Row(
                            "Reverse Banner",
                            row => row
                                .Area(4, area => area.Editor(UmbracoDefaultGridDataType.RichTextEditor, UmbracoDefaultGridDataType.Image, UmbracoDefaultGridDataType.Embed).Editor("BlueLeet.GoogleMaps", "BlueLeet.Quote"))
                                .Area(4, area => area.Editor(UmbracoDefaultGridDataType.RichTextEditor, UmbracoDefaultGridDataType.Image, UmbracoDefaultGridDataType.Embed).Editor("BlueLeet.GoogleMaps", "BlueLeet.Quote", "paragraph", "leadParagraph", "quote_D"))
                                .Area(4, area => area.Editor(UmbracoDefaultGridDataType.RichTextEditor, UmbracoDefaultGridDataType.Image, UmbracoDefaultGridDataType.Embed).Editor("BlueLeet.GoogleMaps", "BlueLeet.Quote", "paragraph", "leadParagraph", "quote_D"))
                                .Area(12, area => area.Editor(UmbracoDefaultGridDataType.RichTextEditor, UmbracoDefaultGridDataType.Image, UmbracoDefaultGridDataType.Embed).Editor("BlueLeet.Headline", "BlueLeet.HeadlineAndLead")));

                        grid.Row(
                            "Banner",
                            row => row
                                .Area(12)
                                .Area(4)
                                .Area(4)
                                .Area(4));

                        grid.Row("Full width content", row => row.Area(12));
                        grid.Row("Two column", row => row.Area(6).Area(6));
                        grid.Row("Three column", row => row.Area(4).Area(4).Area(4));
                        grid.Row("Row 40/60", row => row.Area(4).Area(8));
                        grid.Row("Row 60/40", row => row.Area(8).Area(4));

                        grid.Settings(
                            settings => settings.Add(
                                "Navigationsankare",
                                "Välj en sida att ankra till",
                                "navigationAnchor",
                                "/umbraco/Views/propertyeditors/contentpicker/contentpicker.html",
                                opt => opt.PropertyEditorConfigWithKeys().Value("startNodeId", "-1")));

                        grid.Settings(settings => settings.Add("Class", "Set a css class", "class", "textstring"));
                        grid.Settings(settings => settings.Add("Grid Layout", "Set a layout type", "section-layout", "/App_Plugins/Site/gridEditors/grid-layout/view.html"));

                        grid.Styles(styles => styles.Add("Set a background image", "Set a row background", "background-image", "imagepicker", "url({0})"));
                    }));
        }
    }
}
