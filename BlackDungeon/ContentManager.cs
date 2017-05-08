using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class ContentManager
    {
        public List<string> resourcePathList;
        public int counter;
        public ContentManager(ResourceType resourceType)
        {
            counter = 0;

            var path = string.Empty;
            switch (resourceType)
            {
                case ResourceType.PlayerFootsteps:
                    path = AppSettings.PlayerFootstepDirectory;
                    break;
            }

            resourcePathList = Directory.GetFiles(path).ToList();
        }

        public string GetRandomResourcePath()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            return resourcePathList[rnd.Next(0, resourcePathList.Count-1)];
        }
     
        public string GetNextResourcePath()
        {
            counter += 1;
            if (counter == resourcePathList.Count)
            {
                counter = 0;   
            }

            return resourcePathList[counter];
        }

    }
}
