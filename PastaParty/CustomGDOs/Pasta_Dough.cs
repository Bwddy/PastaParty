using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using KitchenLib.References;
using TestCubes;
using IngredientLib.Ingredient.Items;
using static KitchenData.Item;
using static KitchenData.ItemGroup;

namespace PastaParty
{
    namespace Customs
    {
        public class Pasta_Dough : CustomItemGroup
        {
            public override string UniqueNameID => "Pasta_Dough";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Pasta_Dough", 0.2f, 0.2f, 0.2f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));
            public override List<ItemSet> Sets => new List<ItemSet>
            {
            new ItemSet
            {
            Max = 2,
            Min = 2,
            Items = new List<Item>
            {
                (Item)GDOUtils.GetCustomGameDataObject<UnmixedEggDough>().GameDataObject,
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
}
