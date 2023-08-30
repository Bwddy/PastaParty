using KitchenLib.Customs;
using UnityEngine;
using TestCubes;
using KitchenLib.Utils;
using System.Collections.Generic;
using static KitchenData.Item;
using KitchenData;
using KitchenLib.References;

namespace PastaParty
{
    namespace Customs
    {
        public class Pappardelle : CustomItem
        {
            public override string UniqueNameID => "Pappardelle";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Pappardelle", 0.3f, 0.3f, 0.3f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));
            public override string ColourBlindTag => "P";
            public override List<ItemProcess> Processes => new List<ItemProcess>
            {
            new ItemProcess
            {
                Duration = 1f,
                IsBad = false,
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
                Result = (Item)GDOUtils.GetCustomGameDataObject<Fettuccine>().GameDataObject
            }
            };
        }
    }
}
