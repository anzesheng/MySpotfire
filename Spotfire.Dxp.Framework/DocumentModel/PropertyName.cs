using System;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    /// <summary>
    /// Represents the identity of a property on a<see cref="DocumentNode"/>.
    /// </summary>
    public class PropertyName : IPropertyNameInternals
    {
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyName"/>.
        /// </summary>
        /// <param name="name">The name of the underlying property.</param>
        /// <param name="validatePrefix">True if prefix should be validated for the user of internal prefixes.</param>
        public PropertyName(string name, bool validatePrefix)
        {
            // internal property name should start with $
            this.name = name;
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static PropertyName InternalCreatePropertyName(string name)
        {
            return new PropertyName(name, true);
        }

        public static PropertyName InternalCreateRuntimeConstantPropertyName()
        {
            return new PropertyName($"$RuntimeConstant-{Guid.NewGuid()}", false);
        }
    }
}