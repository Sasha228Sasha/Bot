
using AmeisenBotX.Common.Math;
using AmeisenBotX.Core.Engines.Jobs.Enums;
using AmeisenBotX.Wow.Objects.Enums;
using System.Collections.Generic;

namespace AmeisenBotX.Core.Engines.Jobs.Profiles.Gathering
{
    public class HerbTerokkarProfile : IHerbalismProfile
    {
        public bool IsCirclePath => true;

        public JobType JobType => JobType.Herbalism;

        public List<Vector3> MailboxNodes { get; } =
        [
            new(-2929, 4009, -1),
            new(-2000, 4200, 5),
            new(-3100, 4150, 2)
        ];

        public List<WowHerbId> HerbTypes { get; } =
        [
            WowHerbId.Terocone,
            WowHerbId.Felweed,
            WowHerbId.DreamingGlory,
            WowHerbId.ManaThistle,
            WowHerbId.Ragveil,
            WowHerbId.Earthroot,
        ];

        public List<Vector3> Path { get; } =
        [
            new(-2382, 4075, -7),
            new(-2318, 3926, 1),
            new(-2239, 4006, -24),
            new(-2300, 4100, -15),
            new(-2450, 4150, -10),
            new(-2550, 4200, -5),
            new(-2701, 5414, 7),
            new(-2406, 4994, -30),
            new(-2350, 4800, -20)
        ];

        public override string ToString()
        {
            return "Herbalism: Terokkar Forest";
        }
    }
}
