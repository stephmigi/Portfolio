using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace ObjectModel
{
    public static class ResourceHelpers
    {
        public static string GetString(string set, string key)
        {
            var typeName = "Resources." + set;
            var assembly = Assembly.Load("Resources");
            var manager = new System.Resources.ResourceManager(typeName, assembly);

            try
            {
                return manager.GetString(key, Thread.CurrentThread.CurrentUICulture);
            }

            catch (MissingManifestResourceException)
            {
                return null;
            }

        }
    }
}
