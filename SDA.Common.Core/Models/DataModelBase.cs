namespace SDA.Common.Core.Models
{
    /// <summary>
    /// Represents the base class for data models, providing common properties
    /// such as unique identifier, creation and update timestamps, and status flags.
    /// </summary>
    public class DataModelBase : IDataModel
    {
        /// <summary>
        /// Gets or sets the unique identifier for the data model.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the data model was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the data model was last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who last updated the data model.
        /// </summary>
        public string LastUserUpdated { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the data model was marked as deleted.
        /// </summary>
        [DefaultValue(false)]
        public DateTime? DeletedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the data model is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the data model is active.
        /// </summary>
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
