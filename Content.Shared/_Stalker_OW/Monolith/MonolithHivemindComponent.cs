using Content.Shared.Radio;
using Robust.Shared.GameObjects;

namespace Content.Shared._Stalker_OW.Monolith;

// ST:OW begin
/// <summary>
/// Marks an entity as connected to the Monolith hivemind
/// </summary>
[RegisterComponent]
public sealed partial class MonolithHivemindComponent : Component;

/// <summary>
/// Raised when Monolith sends a message using hivemind
/// </summary>
public sealed class MonolithHivemindMessageEvent(string message, RadioChannelPrototype channel) : EntityEventArgs
{
    public string Message { get; } = message;
    public RadioChannelPrototype Channel { get; } = channel;
}
// ST:OW end