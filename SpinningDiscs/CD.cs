using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(int totalStorage, int remainingStorage, string title) : base(totalStorage, remainingStorage, title)
        {
            TypeOfDisc = "CD";
            RotationsPerMinute = 54321;
        }
    }
}
