// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GridFrontPage.cs" company="BlueLeet">
//   Copyright (C) BlueLeet - All Rights Reserved
//   Unauthorized copying of this file, via any medium is strictly prohibited
//   Proprietary and confidential
// </copyright>
// <summary>
//   Defines the DropdownHairColor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using BlueLeet.UCodeFirst.DataTypes;
using Umbraco.Core.Models;
using Umbraco.Web.PropertyEditors;

namespace UmbracoTest.Web.DataTypes
{
    /// <summary>
    /// The dropdown hair color.
    /// </summary>
    [DataType("Umbraco.Grid", DataType.GridFrontPage, ValueStorageType.Ntext)]
    public class GridFrontPage : DataTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridFrontPage"/> class.
        /// </summary>
        /// <param name="existingPreValues">
        /// The existing pre values.
        /// </param>
        public GridFrontPage(IDictionary<string, object> existingPreValues) : base(existingPreValues)
        {
            var config = new Umbraco.Web.PropertyEditors.GridConfiguration();
            
        }
    }

    public class GridConfigurationBuilder
    {
        public GridConfigurationBuilder()
        {
            Configuration = new GridConfiguration();
        }

        public GridConfigurationBuilder(GridConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Umbraco.Web.PropertyEditors.GridConfiguration Configuration { get; }


    }
}
