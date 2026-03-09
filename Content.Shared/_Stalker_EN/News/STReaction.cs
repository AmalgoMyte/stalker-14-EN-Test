using Robust.Shared.Serialization;

namespace Content.Shared._Stalker_EN.News;

/// <summary>
/// Categorizes what content a reaction targets. Extensible for future content types.
/// </summary>
[Serializable, NetSerializable]
public enum STReactionTargetType : byte
{
    Article = 0,
    Comment = 1,
}

/// <summary>
/// Aggregated reaction data for a single reaction type on a single target.
/// </summary>
[Serializable, NetSerializable]
public readonly record struct STReactionSummary(string ReactionId, int Count, bool UserReacted);

/// <summary>
/// Static registry of available reaction types — faction band patch names.
/// IDs correspond to keys in <c>STFactionPatchIcons.PatchStates</c> on the client.
/// </summary>
public static class STReactionDefinitions
{
    public static readonly HashSet<string> Available = new()
    {
        "Loners",
        "Freedom",
        "Bandits",
        "Duty",
        "Ecologist",
        "Neutrals",
        "Mercenaries",
        "Military",
        "Monolith",
        "ClearSky",
        "Renegades",
        "Rookies",
        "Journalists",
        "UN",
    };
}
