﻿using KitchenLib.Customs;
using UnityEngine;
using TestCubes;
using KitchenLib.Utils;
using KitchenData;
using static KitchenData.Item;
using System.Collections.Generic;
using KitchenLib.References;

namespace PastaParty
{
    namespace Customs
    {
        public class Pasta_Dough_Rolled : CustomItem
        {
            public override string UniqueNameID => "Pasta_Dough_Rolled";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Pasta_Dough_Rolled", 1f, 0.1f, 1f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));

            public override List<ItemProcess> Processes => new List<ItemProcess>
            {
            new ItemProcess
            {
                Duration = 1f,
                IsBad = false,
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
                Result = (Item)GDOUtils.GetCustomGameDataObject<Pappardelle>().GameDataObject
            }
            };
        }
    }
}
