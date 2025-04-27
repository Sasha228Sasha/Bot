using AmeisenBotX.Common.Math;
using AmeisenBotX.Wow.Objects.Enums;
using System.Collections.Generic;

namespace AmeisenBotX.Core.Engines.Jobs.Profiles
{
    public interface IHerbalismProfile : IJobProfile
    {
        bool IsCirclePath { get; }
        List<Vector3> MailboxNodes { get; }
        List<WowHerbId> HerbTypes { get; }
        List<Vector3> Path { get; }
    }
}
