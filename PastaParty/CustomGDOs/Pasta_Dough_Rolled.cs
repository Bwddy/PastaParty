using KitchenLib.Customs;
using UnityEngine;
using TestCubes;
using KitchenLib.Utils;

namespace PastaParty
{
    public class Pasta_Dough_Rolled : CustomItem
    {
        public override string UniqueNameID => "Pasta_Dough_Rolled";
        
        public override GameObject Prefab => TestCubeManager.GetPrefab("Pasta_Dough_Rolled", 0.2f, 0.2f, 0.2f, MaterialUtils.GetExistingMaterial("Lettuce"));

    }
}
