using System;
using System.IO;

namespace mididump2csv {
    class MainClass {
        public static void Main(string[] args) {
            StreamTextReader tr;

            if(args.Length > 0) tr = new StreamTextReader(File.OpenRead(args[0]));
            else tr = new StreamTextReader(Console.OpenStandardInput());

            Console.WriteLine("absoluteTime,event,channel,note,velocity,length"); // csv column names
            string currentLine = null;
            while((currentLine = tr.ReadLine()) != null) {
                currentLine = currentLine.Replace(" Ch: ", " Ch:");

                if(currentLine.Contains("NoteOn")) {
                    currentLine = currentLine
                        .Replace(" Len: ", " Len:")
                        .Replace(" (Note Off)", " (NoteOff)")
                        .Replace("Acoustic Grand", "AcousticGrand")
                        .Replace("Bright Acoustic", "BrightAcoustic");

                    if(currentLine.Contains("Ch:10")) replaceDrumName(ref currentLine);
                }

                Console.WriteLine(string.Join(",", currentLine.Split(' ')));
            }
        }

        public static void replaceDrumName(ref string s) {
            int oldLen = s.Length;
            s = s.Replace("Drum 33", "Drum33");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 34", "Drum34");
            if(s.Length != oldLen) return;
            s = s.Replace("Acoustic Bass Drum", "AcousticBassDrum");
            if(s.Length != oldLen) return;
            s = s.Replace("Bass Drum 1", "BassDrum1");
            if(s.Length != oldLen) return;
            s = s.Replace("Side Stick", "SideStick");
            if(s.Length != oldLen) return;
            s = s.Replace("Acoustic Snare", "AcousticSnare");
            if(s.Length != oldLen) return;
            s = s.Replace("Hand Clap", "HandClap");
            if(s.Length != oldLen) return;
            s = s.Replace("Electric Snare", "ElectricSnare");
            if(s.Length != oldLen) return;
            s = s.Replace("Low Floor Tom", "LowFloorTom");
            if(s.Length != oldLen) return;
            s = s.Replace("Closed Hi-Hat", "ClosedHi-Hat");
            if(s.Length != oldLen) return;
            s = s.Replace("High Floor Tom", "HighFloorTom");
            if(s.Length != oldLen) return;
            s = s.Replace("Pedal Hi-Hat", "PedalHi-Hat");
            if(s.Length != oldLen) return;
            s = s.Replace("Low Tom", "LowTom");
            if(s.Length != oldLen) return;
            s = s.Replace("Open Hi-Hat", "OpenHi-Hat");
            if(s.Length != oldLen) return;
            s = s.Replace("Low-Mid Tom", "Low-MidTom");
            if(s.Length != oldLen) return;
            s = s.Replace("Hi-Mid Tom", "Hi-MidTom");
            if(s.Length != oldLen) return;
            s = s.Replace("Crash Cymbal 1", "CrashCymbal1");
            if(s.Length != oldLen) return;
            s = s.Replace("High Tom", "HighTom");
            if(s.Length != oldLen) return;
            s = s.Replace("Ride Cymbal 1", "RideCymbal1");
            if(s.Length != oldLen) return;
            s = s.Replace("Chinese Cymbal", "ChineseCymbal");
            if(s.Length != oldLen) return;
            s = s.Replace("Ride Bell", "RideBell");
            if(s.Length != oldLen) return;
            s = s.Replace("Tambourine", "Tambourine");
            if(s.Length != oldLen) return;
            s = s.Replace("Splash Cymbal", "SplashCymbal");
            if(s.Length != oldLen) return;
            s = s.Replace("Cowbell", "Cowbell");
            if(s.Length != oldLen) return;
            s = s.Replace("Crash Cymbal 2", "CrashCymbal2");
            if(s.Length != oldLen) return;
            s = s.Replace("Vibraslap", "Vibraslap");
            if(s.Length != oldLen) return;
            s = s.Replace("Ride Cymbal 2", "RideCymbal2");
            if(s.Length != oldLen) return;
            s = s.Replace("Hi Bongo", "HiBongo");
            if(s.Length != oldLen) return;
            s = s.Replace("Low Bongo", "LowBongo");
            if(s.Length != oldLen) return;
            s = s.Replace("Mute Hi Conga", "MuteHiConga");
            if(s.Length != oldLen) return;
            s = s.Replace("Open Hi Conga", "OpenHiConga");
            if(s.Length != oldLen) return;
            s = s.Replace("Low Conga", "LowConga");
            if(s.Length != oldLen) return;
            s = s.Replace("High Timbale", "HighTimbale");
            if(s.Length != oldLen) return;
            s = s.Replace("Low Timbale", "LowTimbale");
            if(s.Length != oldLen) return;
            s = s.Replace("High Agogo", "HighAgogo");
            if(s.Length != oldLen) return;
            s = s.Replace("Low Agogo", "LowAgogo");
            if(s.Length != oldLen) return;
            s = s.Replace("Cabasa", "Cabasa");
            if(s.Length != oldLen) return;
            s = s.Replace("Maracas", "Maracas");
            if(s.Length != oldLen) return;
            s = s.Replace("Short Whistle", "ShortWhistle");
            if(s.Length != oldLen) return;
            s = s.Replace("Long Whistle", "LongWhistle");
            if(s.Length != oldLen) return;
            s = s.Replace("Short Guiro", "ShortGuiro");
            if(s.Length != oldLen) return;
            s = s.Replace("Long Guiro", "LongGuiro");
            if(s.Length != oldLen) return;
            s = s.Replace("Claves", "Claves");
            if(s.Length != oldLen) return;
            s = s.Replace("Hi Wood Block", "HiWoodBlock");
            if(s.Length != oldLen) return;
            s = s.Replace("Low Wood Block", "LowWoodBlock");
            if(s.Length != oldLen) return;
            s = s.Replace("Mute Cuica", "MuteCuica");
            if(s.Length != oldLen) return;
            s = s.Replace("Open Cuica", "OpenCuica");
            if(s.Length != oldLen) return;
            s = s.Replace("Mute Triangle", "MuteTriangle");
            if(s.Length != oldLen) return;
            s = s.Replace("Open Triangle", "OpenTriangle");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 82", "Drum82");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 83", "Drum83");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 84", "Drum84");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 85", "Drum85");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 86", "Drum86");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 87", "Drum87");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 88", "Drum88");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 89", "Drum89");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 90", "Drum90");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 91", "Drum91");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 92", "Drum92");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 93", "Drum93");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 94", "Drum94");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 95", "Drum95");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 96", "Drum96");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 97", "Drum97");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 98", "Drum98");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 99", "Drum99");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 100", "Drum100");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 101", "Drum101");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 102", "Drum102");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 103", "Drum103");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 104", "Drum104");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 105", "Drum105");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 106", "Drum106");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 107", "Drum107");
            if(s.Length != oldLen) return;
            s = s.Replace("Drum 108", "Drum108");
            if(s.Length != oldLen) return;
        }
    }
}
