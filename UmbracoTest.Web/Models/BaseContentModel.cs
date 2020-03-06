// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseContentModel.cs" company="BlueLeet">
//   Copyright (C) BlueLeet - All Rights Reserved
//   Unauthorized copying of this file, via any medium is strictly prohibited
//   Proprietary and confidential
// </copyright>
// <summary>
//   The base content model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using BlueLeet.UCodeFirst;
using BlueLeet.UCodeFirst.Abstraction;
using BlueLeet.UCodeFirst.ContentTypes;
using Newtonsoft.Json.Linq;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using UmbracoTest.Web.Converters;

namespace UmbracoTest.Web.Models
{
    /// <summary>
    /// The base content model.
    /// </summary>
    [ContentType(DisplayName = "Content Base", Variations = ContentVariation.Culture, Icon = Icon.UmbContent)]
    public abstract class BaseContentModel : BaseModel, IRedirect
    {
        /// <inheritdoc />
        public BaseContentModel(IPublishedContent content)
            : base(content)
        {
        }

        /// <summary>
        /// Gets or sets the browser tab text.
        /// </summary>
        [Property(UmbracoDefaultDataType.Textstring, Tab.Seo, DisplayName = "#BrowserTabText name", Description = "#BrowserTabText description", Variations = ContentVariation.Culture)]
        public virtual string BrowserTabText { get; set; }

        /// <summary>
        /// Gets or sets the footer logotype.
        /// </summary>
        [Property(UmbracoDefaultDataType.MediaPicker, Tab.Footer, DisplayName = "#FooterLogotype name", Description = "#FooterLogotype description", Converter = typeof(MediaConverter))]
        public virtual IPublishedContent FooterLogotype { get; set; }

        /// <summary>
        /// Gets or sets the <c>umbraco</c> url alias.
        /// </summary>
        [Property(UmbracoDefaultDataType.Textstring, Tab.Navigation, DisplayName = "#UmbracoUrlAlias name", Description = "#UmbracoUrlAlias description", Variations = ContentVariation.Culture)]
        public virtual string UmbracoUrlAlias { get; set; }

        /// <summary>
        /// Gets or sets the <c>umbraco</c> url name.
        /// </summary>
        [Property(UmbracoDefaultDataType.Textstring, Tab.Navigation, DisplayName = "#UmbracoUrlName name", Description = "#UmbracoUrlName description", Variations = ContentVariation.Culture)]
        public virtual string UmbracoUrlName { get; set; }

        /// <summary>
        /// Gets or sets the main body.
        /// </summary>
        [Property(DataType.GridFrontPage, Tab.ModuleContent, DisplayName = "#GridFrontPage name", Description = "#GridFrontPage description", Variations = ContentVariation.Culture)]
        public virtual JObject GridFrontPage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether hide in navigation.
        /// </summary>
        [Property(UmbracoDefaultDataType.TrueFalse, Tab.Navigation, DisplayName = "#HideInNavigation name", Description = "#HideInNavigation description")]
        public virtual bool HideInNavigation { get; set; }

        /// <summary>
        /// Gets or sets the redirect.
        /// </summary>
        [Property(UmbracoDefaultDataType.Textstring, Tab.Navigation, DisplayName = "#Redirect name", Description = "#Redirect description")]
        public virtual string Redirect { get; set; }

        ///// <summary>
        ///// Gets or sets the search tags.
        ///// </summary>
        //[Property(
        //    UmbracoDefaultDataType.Tags,
        //    Tab.Settings,
        //    DisplayName = "Search Tags",
        //    Description = "Detta är sidans sökbara taggar.")]
        //public virtual string SearchTags { get; set; }

        /// <inheritdoc />
        public string GetRedirectUrl()
        {
            if (string.IsNullOrEmpty(Redirect))
            {
                return string.Empty;
            }

            return Redirect;
        }
    }
}
