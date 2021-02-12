using System;

namespace Delegates
{
    public class PhotoProcessor
    {

        //public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action<>
            //System.Func<> --> has return 

            var photo = Photo.Load(path);

            filterHandler(photo);

        }
    }
}