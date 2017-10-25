namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// ��������
    /// Represents a cross-sell product
    /// </summary>
    public partial class CrossSellProduct : BaseEntity
    {
        /// <summary>
        /// ��Ʒ1
        /// Gets or sets the first product identifier
        /// </summary>
        public int ProductId1 { get; set; }

        /// <summary>
        /// ��Ʒ2
        /// Gets or sets the second product identifier
        /// </summary>
        public int ProductId2 { get; set; }
    }

}
