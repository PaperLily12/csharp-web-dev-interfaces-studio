using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public List<string> StoredData { get; set; } = new List<string>();
        public int TotalStorage { get; set; }
        public int RemainingStorage { get; set; }
        public string Title { get; set; }
        public int RotationsPerMinute { get; set; }
        public string TypeOfDisc { get; set; }

        public BaseDisc(int totalStorage, int remainingStorage, string title)
        {
            TotalStorage = totalStorage;
            RemainingStorage = remainingStorage;
            Title = title;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"The disc is now spinning at {RotationsPerMinute} rpm.");
        }

        public int CheckRemainingStorage()
        {
            int storageCount = 0;
            foreach (string data in StoredData)
            {
                storageCount += data.Length;
            }
            return TotalStorage - storageCount;
        }

        public int WriteToDisc(string dataToWrite)
        {
            if (CheckRemainingStorage() > dataToWrite.Length)
            {
                StoredData.Add(dataToWrite);
            }
            return CheckRemainingStorage();
        }
    }
}
