<<<<<<< HEAD
using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.Manual
{
    /// <summary>
    /// Represents settings of manual payment plugin
    /// </summary>
    public class ManualPaymentSettings : ISettings
    {
        /// <summary>
        /// Gets or sets payment transaction mode
        /// </summary>
        public TransactMode TransactMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to "additional fee" is specified as percentage. true - percentage, false - fixed value.
        /// </summary>
        public bool AdditionalFeePercentage { get; set; }

        /// <summary>
        /// Gets or sets an additional fee
        /// </summary>
        public decimal AdditionalFee { get; set; }
    }
}
=======
using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.Manual
{
    /// <summary>
    /// Represents settings of manual payment plugin
    /// </summary>
    public class ManualPaymentSettings : ISettings
    {
        /// <summary>
        /// Gets or sets payment transaction mode
        /// </summary>
        public TransactMode TransactMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to "additional fee" is specified as percentage. true - percentage, false - fixed value.
        /// </summary>
        public bool AdditionalFeePercentage { get; set; }

        /// <summary>
        /// Gets or sets an additional fee
        /// </summary>
        public decimal AdditionalFee { get; set; }
    }
}
>>>>>>> 174426a8e1a9c69225a65c26a93d9aa871080855
