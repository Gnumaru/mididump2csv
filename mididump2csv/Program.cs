using System;
using System.IO;

namespace mididump2csv {
    class MainClass {
        public static void Main(string[] args) {
            Stream input = null;

            if(args.Length > 0) input = File.OpenRead(args[0]);
            else input = Console.OpenStandardInput();
            
            TextReader tr = new StringReader(new StreamReader(input).ReadToEnd());

            string line = string.Empty;
            Console.WriteLine("absoluteTime,event,channel,note,velocity,length"); // csv column names
            while((line = tr.ReadLine()) != null) {
                line = line
                    .Replace(" Ch: ", " Ch:")
                    .Replace(" Len: ", " Len:")
                    .Replace(" (Note Off)", " (NoteOff)")
                    .Replace("Bass Drum 1", "BassDrum1")
                    .Replace("Electric Snare", "ElectricSnare")
                    .Replace("Closed Hi-Hat", "ClosedHi-Hat")
                    .Replace("Bright Acoustic", "BrightAcoustic")
                    .Replace("Acoustic Grand", "AcousticGrand");
                Console.WriteLine(string.Join(",", line.Split(' ')));
            }
        }
    }
}
