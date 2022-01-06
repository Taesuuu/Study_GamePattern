using System.Collections.Generic;
 
namespace Flyweight
{
    class MetaPool 
    {
        List<Meta> metas = new List<Meta>(); 
 
        public static MetaPool Singleton 
        {
            get;
            private set;
        } 
 
        static MetaPool()
        {
            Singleton = new MetaPool();
        }
 
        private MetaPool()
        {
        } 

        public Meta MakeMeta(BodyType body,LensType lens,LightType light)
        {
            foreach (Meta meta in metas)
            {
                if (meta.IsEqual(body, lens, light))
                {
                    return meta; 
                }
            }

            Meta m = new Meta(body,lens,light); 
            metas.Add(m);
            return m; 
        }
    }
}