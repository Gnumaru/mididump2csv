using System;

namespace mididump2csv {
    class MainClass {
        public static void Main(string[] args) {
            string line = string.Empty;
            while((line = Console.ReadLine()) != null) {
                line = line
                    .Replace(" Ch: ", " Ch:")
                    .Replace(" Len: ", " Len:")
                    .Replace(" (Note Off)", " (NoteOff)")
                    .Replace("Bass Drum 1", "BassDrum1")
                    .Replace("Electric Snare", "ElectricSnare")
                    .Replace("Bright Acoustic", "BrightAcoustic")
                    .Replace("Acoustic Grand", "AcousticGrand");
                Console.WriteLine(string.Join(",", line.Split(' ')));
            }
        }
    }
}
//.Replace()