using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using TestCubes;
using UnityEngine;

namespace PastaParty
{
    namespace Customs
    {
        public class SemolinaProvider : CustomAppliance
        {
            public override string UniqueNameID => "SemolinaProvider";

            public override GameObject Prefab => TestCubeManager.GetPrefab("SemolinaProvider", 1, 1, 1, MaterialUtils.GetExistingMaterial("Wood - Default"));

            public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)> { ((Locale)1, new ApplianceInfo
            {
            Name = "SemolinaBag",
            Description = "Provides Semolina",
            }) };

            public override List<IApplianceProperty> Properties => new List<IApplianceProperty> { (IApplianceProperty)(object)KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<Semolina>().GameDataObject.ID) };
        }
    }
}
