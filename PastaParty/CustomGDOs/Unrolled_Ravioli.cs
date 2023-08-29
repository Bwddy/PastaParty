using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using static KitchenData.Item;
using UnityEngine;
using static KitchenData.ItemGroup;
using KitchenLib.References;
using TestCubes;
using IngredientLib.Ingredient.Items;

namespace PastaParty
{
    namespace Customs
    {
        public class Unrolled_Ravioli : CustomItemGroup
        {
            public override string UniqueNameID => "Unrolled_Ravioli";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Unrolled_Ravioli", 1f, 0.2f, 1f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));
            public override List<ItemSet> Sets => new List<ItemSet>
        {
        new ItemSet
        {
            Max = 2,
            Min = 2,
            Items = new List<Item>
            {
                (Item)GDOUtils.GetCustomGameDataObject<Pasta_Dough_Rolled>().GameDataObject,
                (Item)GDOUtils.GetCustomGameDataObject<Ricotta>().GameDataObject
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
            Result = (Item)GDOUtils.GetCustomGameDataObject<Ravioli>().GameDataObject
        }
        };
        }
    }
}
