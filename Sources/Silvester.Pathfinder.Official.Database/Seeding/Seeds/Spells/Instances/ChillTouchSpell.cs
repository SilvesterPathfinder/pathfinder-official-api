﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ChillTouchSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Cantrip";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("4ab38c95-8b8a-4f7c-b260-1b842a91ace3"),
                Name = "Chill Touch",
                Description = "Siphoning negative energy into yourself, your hand radiates a pale darkness. Your touch weakens the living and disorients undead, possibly even causing them to flee. The effect depends on whether the target is living or undead.",
                Level = 1,
                Range = 0,
                Targets = "1 living or undead creature."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("a08010bb-278e-457b-8a83-9bd955303460"), Text = "- Living Creature: The spell deals negative damage equal to 1d4 plus your spellcasting modifier. The target attempts a basic Fortitude save, but is also enfeebled 1 for 1 round on a critical failure." };
            yield return new SpellDetailBlock { Id = Guid.Parse("5a911837-34c2-47c2-b348-125d22fea173"), Text = "- Undead Creature: The target is flat-footed for 1 round on a failed Fortitude save. On a critical failure, the target is also fleeing for 1 round unless it succeeds at a Will save. Heightened (+1)" };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("4c4341f2-16d9-4a55-b504-418231e4b9fe"), Level = 1, Description = "The negative damage to living creatures increases by 1d4." };
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
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Cantrip";
            yield return "Necromancy";
            yield return "Negative";
        }
    }
}
