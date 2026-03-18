using Content.Shared.Teleportation.Components;
using Robust.Shared.Timing;

namespace Content.Server._Stalker_EN.Teleportation;

/// <summary>
/// This handles Portal timeout cooldowns
/// </summary>
public sealed class PortalTimeoutSystem : EntitySystem
{
    [Dependency] private readonly IGameTiming _timing = default!;
    public override void Update(float frameTime)
    {
        var query = EntityQueryEnumerator<PortalTimeoutComponent>();

        while (query.MoveNext(out var uid, out var timeout))
        {
            if (timeout.Cooldown <= _timing.CurTime)
                RemCompDeferred<PortalTimeoutComponent>(uid);
        }
    }
}
