using System;
namespace Flyweight
{
    class PictureFile
    {
        string name;
        Meta meta; 
        public PictureFile(string name,BodyType body,LensType lens,LightType light)
        {
            MetaPool meta_pool = MetaPool.Singleton;
            this.name = name;
            meta = meta_pool.MakeMeta(body,lens,light); 
        }
        public void View()
        {
            Console.WriteLine("사진 이름: {0}",name);
            meta.View();
        }
    }
}