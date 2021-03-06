﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class StreetwiseFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("7de0d323-fc78-4154-a4d0-91e8af5ef631"),
                Name = "Streetwise",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("b49e4a7d-a147-40c2-a552-b71770e29367"), Text = "You know about life on the streets and feel the pulse of your local settlement. You can use your Society modifier instead of your Diplomacy modifier to Gather Information. In any settlement you frequent regularly, you can use the Recall Knowledge action with Society to know the same sorts of information that you could discover with Diplomacy to Gather Information. The DC is usually significantly higher, but you know the information without spending time gathering it. If you fail to recall the information, you can still subsequently attempt to Gather Information normally." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("7417ee71-aa5a-4d7e-89f4-a7c2f1fbb3f0"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Trained")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
