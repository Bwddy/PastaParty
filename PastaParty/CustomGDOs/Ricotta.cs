using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;

namespace PastaParty
{
    namespace Customs
    {
        public class Ricotta : CustomItem
        {
            public override string UniqueNameID => "Ricotta";

            public override GameObject Prefab => TestCubeManager.GetPrefab("Ricotta", 0.2f, 0.2f, 0.2f, MaterialUtils.GetExistingMaterial("Cheese - Default"), false);

            public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<RicottaProvider>().GameDataObject;
        }
    }
}