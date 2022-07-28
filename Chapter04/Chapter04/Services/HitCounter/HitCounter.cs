using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter04.Services.HitCounter
{
    public class HitCounter : IHitCounter
    {
        private string rootPath;


        public HitCounter(string path)
        {
            rootPath = path;
        }


        public int UpdateCount()
        {
            string filePath = "\\hitcount.txt";
            string fullPath = string.Concat(rootPath, filePath);
            int count = int.Parse(File.ReadAllText(fullPath));
            count++;
            File.WriteAllText(fullPath, count.ToString());

            return count;
        }
    }
}
