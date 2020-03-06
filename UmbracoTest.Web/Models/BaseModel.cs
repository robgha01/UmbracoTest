// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseModel.cs" company="BlueLeet">
//   Copyright (C) BlueLeet - All Rights Reserved
//   Unauthorized copying of this file, via any medium is strictly prohibited
//   Proprietary and confidential
// </copyright>
// <summary>
//   Defines the BaseModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using BlueLeet.UCodeFirst;
using BlueLeet.UCodeFirst.ContentTypes;
using BlueLeet.UCodeFirst.Extensions;
using Umbraco.Core.Models.PublishedContent;

namespace UmbracoTest.Web.Models
{
    [ContentType(DisplayName = "Base", Icon = Icon.Brick)]
    public abstract class BaseModel : UCodeFirstContentTypeBase
    {
        protected BaseModel(IPublishedContent content)
            : base(content)
        {
        }

        public StartPageModel StartPage => this.AncestorOrSelf<StartPageModel>(1);
    }
}