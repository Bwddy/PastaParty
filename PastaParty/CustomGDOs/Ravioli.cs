using KitchenLib.Customs;
using UnityEngine;
using TestCubes;
using KitchenLib.Utils;

namespace PastaParty
{
    namespace Customs
    {
        public class Ravioli : CustomItem
        {
            public override string UniqueNameID => "Ravioli";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Ravioli", 0.2f, 0.2f, 0.2f, MaterialUtils.GetExistingMaterial("Cheese - Pizza"));
            public override string ColourBlindTag => "R";
        }
    }
}
