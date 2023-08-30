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
        public class Tagliatelle : CustomItem
        {
            public override string UniqueNameID => "Tagliatelle";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Tagliatelle", 0.3f, 0.3f, 0.3f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));

            public override string ColourBlindTag => "T";
        }
    }
}
