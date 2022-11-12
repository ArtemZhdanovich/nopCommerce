<<<<<<< HEAD
namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product template
    /// </summary>
    public partial class ProductTemplate : BaseEntity
    {
        /// <summary>
        /// Gets or sets the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the view path
        /// </summary>
        public string ViewPath { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of product type identifiers NOT supported by this template
        /// </summary>
        public string IgnoredProductTypes { get; set; }
    }
}
=======
namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product template
    /// </summary>
    public partial class ProductTemplate : BaseEntity
    {
        /// <summary>
        /// Gets or sets the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the view path
        /// </summary>
        public string ViewPath { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of product type identifiers NOT supported by this template
        /// </summary>
        public string IgnoredProductTypes { get; set; }
    }
}
>>>>>>> 174426a8e1a9c69225a65c26a93d9aa871080855
