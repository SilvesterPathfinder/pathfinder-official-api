﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class TrainAnimalFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("d1d5b37b-2fcd-4699-892f-5c81cc437323"),
                Name = "Train Animal",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("13825e71-f1db-4f44-9ec8-3bdf31a04712"), Text = "You spend time teaching an animal to do a certain action. You can either select a basic action the animal already knows how to do (typically those listed in the Command an Animal action on page 249) or attempt to teach the animal a new basic action. The GM determines the DC of any check required and the amount of time the training takes (usually at least a week). It’s usually impossible to teach an animal a trick that uses critical thinking. If you’re expert, master, or legendary in Nature, you might be able to train more unusual creatures, at the GM’s discretion." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("8954ba73-8dcd-4563-8ee4-ce46f9f24726"), RequiredSkillId = seeder.GetSkill("Nature"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e2d96fa8-70a4-45cf-b7a1-010a8790b583"),
                Success = "The animal learns the action. If it was an action the animal already knew, you can Command the Animal to take that action without attempting a Nature check. If it was a new basic action, add that action to the actions the animal can take when Commanded, but you must still roll.",
                Failure = "The animal doesn’t learn the trick."
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Downtime";
            yield return "General";
            yield return "Manipulate";
            yield return "Skill";
        }
    }
}
