using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iamsng.Core.Entities;

/// <summary>
/// Base entity class providing common audit functionality for all entities
/// Implements DoD security requirements and FIPS 140-3 compliance standards
/// All domain entities should inherit from this base class for consistent audit trails
/// </summary>
public abstract class BaseEntity
{
    #region Audit Fields

    /// <summary>
    /// Timestamp when the record was created
    /// Required for DoD audit compliance per STIG V-222430
    /// </summary>
    [Column("created_at")]
    [Required]
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// User ID who created the record
    /// Foreign key reference to user table for audit trail
    /// </summary>
    [Column("created_by")]
    [Required]
    public int CreatedBy { get; set; }

    /// <summary>
    /// Timestamp when the record was last modified
    /// Null if never modified after creation
    /// </summary>
    [Column("modified_at")]
    public DateTimeOffset? ModifiedAt { get; set; }

    /// <summary>
    /// User ID who last modified the record
    /// Foreign key reference to user table for audit trail
    /// </summary>
    [Column("modified_by")]
    public int? ModifiedBy { get; set; }

    #endregion

    #region Optimistic Locking

    /// <summary>
    /// Version number for optimistic locking
    /// Prevents concurrent update conflicts in multi-user environment
    /// Increments with each update
    /// </summary>
    [Column("version")]
    [ConcurrencyCheck]
    [Required]
    public int Version { get; set; } = 1;

    #endregion

    #region Helper Methods

    /// <summary>
    /// Updates the modified audit fields
    /// Call this before saving changes to an existing entity
    /// </summary>
    /// <param name="userId">ID of the user making the modification</param>
    public virtual void SetModified(int userId)
    {
        ModifiedAt = DateTimeOffset.UtcNow;
        ModifiedBy = userId;
        Version++;
    }

    /// <summary>
    /// Sets the creation audit fields
    /// Call this when creating a new entity
    /// </summary>
    /// <param name="userId">ID of the user creating the record</param>
    public virtual void SetCreated(int userId)
    {
        CreatedAt = DateTimeOffset.UtcNow;
        CreatedBy = userId;
        Version = 1;
    }

    /// <summary>
    /// Checks if the entity has been modified since creation
    /// </summary>
    [NotMapped]
    public bool HasBeenModified => ModifiedAt.HasValue;

    /// <summary>
    /// Gets the age of the record
    /// </summary>
    [NotMapped]
    public TimeSpan Age => DateTimeOffset.UtcNow - CreatedAt;

    #endregion
}