using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public static class AppSettings
    {
        public static string GetGameDirectory
        {
            get
            {
                return
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
        }

        public static string PlayerFootstepDirectory
        {
            get
            {
                return @"Content\Sound\Player\Footstep";
            }
        }
    }
}