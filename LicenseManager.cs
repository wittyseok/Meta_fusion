using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metafusion
{
    internal class LicenseManager
    {
        public static List<string> Licenses { get; private set; } = new List<string>();

        public static void LoadLicenses(List<string> licenses)
        {
            Licenses = licenses;
        }

        public static bool HasLicense(string feature)
        {
            return Licenses.Contains(feature);
        }

        public static List<string> GetLicenses()
        {
            Licenses = new List<string> { "home", "item1", "item3", "item5", "itemtooth", "viewer" }; // TODO: 실제로는 서버에서 받아옴
            return Licenses;
        }
    }
}
