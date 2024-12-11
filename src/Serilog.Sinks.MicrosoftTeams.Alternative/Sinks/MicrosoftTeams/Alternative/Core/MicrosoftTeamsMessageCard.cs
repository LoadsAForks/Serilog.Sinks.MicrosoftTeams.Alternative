// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MicrosoftTeamsMessageCard.cs" company="SeppPenner and the Serilog contributors">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   The teams message card.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Serilog.Sinks.MicrosoftTeams.Alternative.Core;

/// <summary>
/// The teams message card.
/// </summary>
internal class MicrosoftTeamsMessageCard
{
    /// <summary>
    /// Gets the type of the card.
    /// </summary>
    [JsonProperty("@type")]
    public string Type { get; } = "MessageCard";

    /// <summary>
    /// Gets the context of the card.
    /// </summary>
    [JsonProperty("@context")]
    public string Context { get; } = "http://schema.org/extensions";

    /// <summary>
    /// Gets or sets the title of the card.
    /// </summary>
    [JsonProperty("title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the text of the card.
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the theme color of the card.
    /// </summary>
    [JsonProperty("themeColor")]
    public string Color { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sections of the card.
    /// </summary>
    [JsonProperty("sections")]
    public IList<MicrosoftTeamsMessageSection> Sections { get; set; } = [];

    /// <summary>
    /// Gets or sets the potential action buttons.
    /// </summary>
    [JsonProperty("potentialAction")]
    public IList<MicrosoftTeamsMessageAction> PotentialActions { get; set; } = [];
}
