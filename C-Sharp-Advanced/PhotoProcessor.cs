using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Advanced
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); 

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            //System.Action<> --> Points to method that returns void
            //System.Func<> --> Points to method that returns something

            //delegates and interfaces can both solve this problem. Interfaces would use some type of polymorphism.
            var photo = Photo.Load(path);

            //var filters = new PhotoFilter();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            filterHandler(photo);

            photo.Save();
        }

    }
}
