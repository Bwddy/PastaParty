using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using TestCubes;

namespace KitchenMyMod
{
    public class Semolina : CustomItem
    {
        public override string UniqueNameID => "Semolina";

        public override GameObject Prefab => TestCubeManager.GetPrefab("Semolina", 0.2f, 0.2f, 0.2f);

        public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<SemolinaProvider>().GameDataObject;
    }
}
