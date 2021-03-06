﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class PickpocketFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        public static readonly Guid ID = Guid.Parse("d1f81e6f-f97f-4bf3-8ddb-7db5ff7c351c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pickpocket",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("d5968cb8-d28f-4615-a56a-00d65455649b"), Text = "You can Steal or Palm an Object that’s closely guarded, such as in a pocket, without taking the –5 penalty. You can’t steal objects that would be extremely noticeable or time consuming to remove (like worn shoes or armor or actively wielded objects). If you’re a master in Thievery, you can attempt to Steal from a creature in combat or otherwise on guard. When doing so, Stealing requires 2 manipulate actions instead of 1, and you take a –5 penalty." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("05e666ea-feb4-4bf6-8d68-098d8435c5ae"), RequiredSkillId = seeder.GetSkill("Thievery"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
