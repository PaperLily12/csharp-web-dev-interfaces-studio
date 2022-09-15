using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(int totalStorage, int remainingStorage, string title) : base(totalStorage, remainingStorage, title)
        {
            TypeOfDisc = "DVD";
            RotationsPerMinute = 12345;
        }
    }
}
