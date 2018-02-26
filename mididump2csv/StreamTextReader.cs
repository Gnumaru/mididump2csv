using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mididump2csv {
    class StreamTextReader : TextReader {
        //public static readonly TextReader Null { }
        private Stream stream;
        public StreamTextReader(Stream stream) {
            this.stream = stream;
        }

        //public static TextReader Synchronized(TextReader reader) { }
        //public override void Close() { }
        //public void Dispose() { }
        //public override int Peek() { }
        //public override int Read() { }
        //public override int Read(char[] buffer, int index, int count) { }
        //public override Task<int> ReadAsync(char[] buffer, int index, int count) { }
        //public override int ReadBlock(char[] buffer, int index, int count) { }
        //public override Task<int> ReadBlockAsync(char[] buffer, int index, int count) { }

        public override string ReadLine() {
            if(sb == null) sb = new StringBuilder();
            else sb.Clear();
            byte[] buffer = new byte[1];
            int total = 0, readCount = 0;
            while((readCount = stream.Read(buffer, 0, 1)) != 0) {
                total++;
                char c = (char)buffer[0];
                if(c == '\n') break;
                sb.Append(c);
            }
            if(total == 0) return null; // muste necessarily return null when stream ends
            var s = sb.ToString();
            sb.Clear();
            return s;
        }

        //public override Task<string> ReadLineAsync() { }
        //public override string ReadToEnd() { }
        //public override Task<string> ReadToEndAsync() { }
        //protected override void Dispose(bool disposing) { }

        private StringBuilder sb;
    }
}
