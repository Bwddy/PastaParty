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
        public class Fettuccine : CustomItem
        {
            public override string UniqueNameID => "Fettuccine";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Fettuccine", 0.3f, 0.3f, 0.3f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));
            public override string ColourBlindTag => "F";
            public override List<ItemProcess> Processes => new List<ItemProcess>
            {
            new ItemProcess
            {
                Duration = 1f,
                IsBad = false,
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
                Result = (Item)GDOUtils.GetCustomGameDataObject<Tagliatelle>().GameDataObject
            }
            };
        }
    }
}
