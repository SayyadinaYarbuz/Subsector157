namespace Content.Server._NF.Cargo.Components;

/// <summary>
/// This is used for calculating the price of mobs.
/// </summary>
[RegisterComponent]
public sealed partial class MobPriceComponent : Component
{
    /// <summary>
    /// How much of a penalty per part there should be. This is a multiplier for a multiplier, the penalty for each body part is calculated from the total number of slots, and then multiplied by this.
    /// </summary>
    [DataField]
    public double MissingBodyPartPenalty = 1.0f;

    /// <summary>
    /// The base price this mob should fetch.
    /// </summary>
    [DataField(required: true)]
    public double Price;

    /// <summary>
    /// The percentage of the actual price that should be granted should the appraised mob be dead.
    /// </summary>
    [DataField]
    public double DeathPenalty = 0.2f;

    /// <summary>
    /// The percentage of the actual price that should be granted should the appraised mob be lab grown calc added after DeathPenalty, will use tag "LabGrown".
    /// </summary>
    [DataField]
    public double LabGrownPenalty = 0.2f;
}
