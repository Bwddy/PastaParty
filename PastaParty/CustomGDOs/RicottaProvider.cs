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
        public class RicottaProvider : CustomAppliance
        {
            public override string UniqueNameID => "RicottaProvider";

            public override GameObject Prefab => TestCubeManager.GetPrefab("RicottaProvider", 1, 1, 1, MaterialUtils.GetExistingMaterial("Cheese - Default"));

            public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)> { ((Locale)1, new ApplianceInfo
            {
            Name = "RicottaBowl",
            Description = "Provides Ricotta",
            }) };

            public override List<IApplianceProperty> Properties => new List<IApplianceProperty> { (IApplianceProperty)(object)KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<Ricotta>().GameDataObject.ID) };
        }
    }
}
