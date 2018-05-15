using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Abstract_Factory
{
    public class AbstractFactory
    {
        interface IMobilePhone
        {
            ISmartPhone GetSmartPhone();
            INormalPhone GetNormalPhone();
        }

        class Nokia : IMobilePhone
        {
            public ISmartPhone GetSmartPhone()
            {
                return new NokiaPixel();
            }

            public INormalPhone GetNormalPhone()
            {
                return new Nokia1600();
            }
        }

        class Samsung : IMobilePhone
        {
            public ISmartPhone GetSmartPhone()
            {
                return new SamsungGalaxy();
            }

            public INormalPhone GetNormalPhone()
            {
                return new SamsungGuru();
            }
        }

        interface ISmartPhone
        {
            string GetModelDetails();
        }

        interface INormalPhone
        {
            string GetModelDetails();
        }

        class NokiaPixel : ISmartPhone
        {
            public string GetModelDetails()
            {
                return "Model : Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
            }
        }

        class SamsungGalaxy : ISmartPhone
        {
            public string GetModelDetails()
            {
                return "Model : Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
            }
        }

        class Nokia1600 : INormalPhone
        {
            public string GetModelDetails()
            {
                return "Model : Nokia 1600\nRAM: NA\nCamera: NA\n";
            }
        }

        class SamsungGuru : INormalPhone
        {
            public string GetModelDetails()
            {
                return "Model : Samsung Guru\nRAM: NA\nCamera: NA\n";
            }
        }

        class MobileClient
        {
            ISmartPhone smartPhone;
            INormalPhone normalPhone;

            public MobileClient(IMobilePhone factory)
            {
                smartPhone = factory.GetSmartPhone();
                normalPhone = factory.GetNormalPhone();
            }

            public string GetSmartPhoneModelDetails()
            {
                return smartPhone.GetModelDetails();
            }

            public string GetNormalPhoneModelDetails()
            {
                return normalPhone.GetModelDetails();
            }
        }

        public static string MainFn()
        {
            string result = string.Empty;
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            result += nokiaClient.GetSmartPhoneModelDetails();
            result += nokiaClient.GetNormalPhoneModelDetails();

            IMobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            result += samsungClient.GetSmartPhoneModelDetails();
            result += samsungClient.GetNormalPhoneModelDetails();

            return result;
        }
    }
}