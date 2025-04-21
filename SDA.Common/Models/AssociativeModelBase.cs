namespace SDA.Common.Models
{
    /// <summary>
    /// Represents the base class for associative models with audit trail properties.
    /// </summary>
    public class AssociativeModelBase : IAuditTrail
    {
        /// <summary>
        /// Gets or sets the date when the entity was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the entity was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the username of the last user who updated the entity.
        /// </summary>
        public string LastUserUpdated { get; set; }

        /// <summary>
        /// Gets or sets the date when the entity was marked as deleted, if applicable.
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is marked as deleted.
        /// </summary>
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is active.
        /// </summary>
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
