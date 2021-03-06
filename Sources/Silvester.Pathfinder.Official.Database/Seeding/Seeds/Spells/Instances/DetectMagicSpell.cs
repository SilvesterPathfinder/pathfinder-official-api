﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectMagicSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Cantrip";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("1e7838ee-f64d-4806-8d3d-e55ba4261c03"),
                Name = "Detect Magic",
                Description = "You send out a pulse that registers the presence of magic. You receive no information beyond the presence or absence of magic. You can choose to ignore magic you’re fully aware of, such as the magic items and ongoing spells of you and your allies.",
                Level = 1,
                Area = "30-foot emanation"
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("ba775672-2c5d-43a3-a002-e1214d439f7e"), Text = "You detect illusion magic only if that magic’s effect has a lower level than the level of your detect magic spell. However, items that have an illusion aura but aren’t deceptive in appearance (such as an invisibility potion) typically are detected normally." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("c9d1c03b-32b0-4182-ad71-89f87576f5a7"), Level = 3, Description = "You learn the school of magic for the highestlevel effect within range that the spell detects. If multiple effects are equally strong, the GM determines which you learn." };
            yield return new SpellHeightening { Id = Guid.Parse("0e4f844c-c605-4423-9321-ca5241df1950"), Level = 4, Description = "As 3rd level, but you also pinpoint the source of the highest-level magic. Like for an imprecise sense, you don’t learn the exact location, but can narrow down the source to within a 5-foot cube (or the nearest if larger than that)." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Divine";
            yield return "Occult";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Cantrip";
            yield return "Detection";
            yield return "Divination";
        }
    }
}
