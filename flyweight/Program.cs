using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            BodyType body_type = BodyType.EH_BA;
            LensType lens_type = LensType.EH_L1;
            LightType light_type = LightType.LT_CLEAR;
 
            PictureFile pf = new PictureFile("사진1", body_type, lens_type, light_type);
            PictureFile pf2 = new PictureFile("사진2", body_type, lens_type, light_type);
            PictureFile pf3 = new PictureFile("사진3", BodyType.EH_BB, LensType.EH_L2, light_type);
            pf.View();
            pf2.View();
            pf3.View();
        }
    }
}
