using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using static KitchenData.Item;
using UnityEngine;
using static KitchenData.ItemGroup;
using KitchenLib.References;
using TestCubes;

namespace KitchenMyMod
{
    public class Pasta_Dough : CustomItemGroup
    {
        public override string UniqueNameID => "Pasta_Dough";

        public override GameObject Prefab => TestCubeManager.GetPrefab("Pasta_Dough", 0.2f, 0.2f, 0.2f);
        public override List<ItemSet> Sets => new List<ItemSet>
        {
        new ItemSet
        {
            Max = 3,
            Min = 3,
            Items = new List<Item>
            {
                (Item)GDOUtils.GetExistingGDO(ItemReferences.EggCracked),
                (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour),
                (Item)GDOUtils.GetCustomGameDataObject<Semolina>().GameDataObject

            },
            IsMandatory = true
        }
        };
        public override List<ItemProcess> Processes => new List<ItemProcess>
    {
        new ItemProcess
        {
            Duration = 1f,
            IsBad = false,
            Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead),
            Result = (Item)GDOUtils.GetCustomGameDataObject<Pasta_Dough_Rolled>().GameDataObject
        }
    };
    }
}
