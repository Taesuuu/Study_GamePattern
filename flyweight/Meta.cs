using System;
 
namespace Flyweight
{

    public enum BodyType { EH_BA, EH_BB, EH_BC };
    public enum LensType { EH_L1, EH_L2, EH_L3 };
    public enum LightType { LT_CLEAR, LT_CLOUDY, LT_LAMP };
 
    class Meta 
    { 
        static string[] bodyname = {"EH_BA","EH_BB","EH_BC"};
        static string[] lensname = { "EH_L1", "EH_L2", "EH_L3" };
        static string[] lightname = { "맑음", "흐림", "램프" };
 

        public BodyType Body 
        {
            get;
            private set;
        }
        public LensType Lens 
        {
            get;
            private set;
        }
        public LightType Light
        {
            get;
            private set;
        }
 
        readonly int seq;
        static int scnt;
 
        public Meta(BodyType body,LensType lens,LightType light)
        {
            scnt++;
            seq = scnt; 
            Body= body;
            Lens = lens;
            Light = light;
        }
        
        public bool IsEqual(BodyType body,LensType lens,LightType light)
        {
            return (Body==body)&&(Lens==lens)&&(Light==light);
        }
 
        public void View()
        {
            Console.WriteLine("일련번호:{0}", seq);
            Console.WriteLine("Body:{0}",bodyname[(int)Body]);
            Console.WriteLine("Lens:{0}", lensname[(int)Lens]);
            Console.WriteLine("Light:{0}", lightname[(int)Light]);
        }
    }
}