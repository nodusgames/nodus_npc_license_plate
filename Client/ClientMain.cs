using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace Nodus.BritishPlates.Client
{
    public class ClientMain : BaseScript
    {
        public ClientMain()
        {
            var pattern = API.GetConvar("license_plate_pattern", "AA11-AAA");
            API.SetDefaultVehicleNumberPlateTextPattern(-1, pattern);
        }
    }
}