using System;
using System.Reflection;
using BlueLeet.UCodeFirst.Abstraction;
using BlueLeet.UCodeFirst.Converters;
using Umbraco.Core;
using Umbraco.Web;

namespace UmbracoTest.Web.Converters
{
    /// <summary>
    /// The media converter.
    /// </summary>
    public class MediaConverter : UCodeFirstConverterBase
    {
        public MediaConverter(IModelResolver modelResolver, IUmbracoContextFactory factory) : base(modelResolver, factory)
        {
        }

        /// <inheritdoc />
        public override object Read(PropertyInfo propertyInfo, object value)
        {
            if (value is int id)
            {
                return Context.Media.GetById(id);
            }

            if (value is Guid guid)
            {
                return Context.Media.GetById(guid);
            }

            if (value is Udi udi)
            {
                return Context.Media.GetById(udi);
            }

            return null;
        }
    }
}