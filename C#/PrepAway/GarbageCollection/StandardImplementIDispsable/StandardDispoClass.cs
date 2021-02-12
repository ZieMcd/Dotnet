using System;

namespace StandardImplementIDispsable
{
    public class StandardDispoClass : IDisposable  // This a example of the stadard to implement a IDisopable to a class that uses it
    {
        private bool _disposed; // used to keep track if dispose has been called on this object, automatically set to false 

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~StandardDispoClass()  // this is the finalizer
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(_disposed)  // if _disposed is true that means we already ran dispose code
                return;    // so just do nothing, the rest of the methode wont excute

            if (disposing) // disposing is true this means that this methode protected virtual void Dispose(bool disposing) is being invoke by user if not its being invoked by GC
            {
                //free other managed objects
                //implement IDisposable only
            }
            //release any unmanaged objects
            //sset the object references to null

            _disposed = true; // so we know that dispose has ran on this objects
        }

    }
}