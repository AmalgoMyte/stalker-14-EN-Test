using Robust.Shared.GameObjects;

namespace Content.Shared._Stalker_EN.MercBoard;

/// <summary>
/// Marker component for the mercenary offers board PDA cartridge.
/// All mutable server state lives in the server-only STMercBoardServerComponent.
/// This shared component exists for YAML prototype registration and the UIFragment system.
/// </summary>
[RegisterComponent]
public sealed partial class STMercBoardComponent : Component;
