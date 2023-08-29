using KitchenLib.Customs;
using UnityEngine;
using TestCubes;
using KitchenLib.Utils;

namespace PastaParty
{
    namespace Customs
    {
        public class Pasta_Dough_Rolled : CustomItem
        {
            public override string UniqueNameID => "Pasta_Dough_Rolled";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Pasta_Dough_Rolled", 1f, 0.1f, 1f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));

        }
    }
}
