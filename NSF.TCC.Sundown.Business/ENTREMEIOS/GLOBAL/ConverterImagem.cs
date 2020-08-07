using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF.TCC.Sundown.Business
{
    public class ConverterImagem
    {

        public byte[] Convert(string caminhofoto)
        {
            FileStream fstream = new FileStream(caminhofoto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            byte[] imagembyte = br.ReadBytes((int)fstream.Length);

            return imagembyte;
        }
    }
}
