﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace ObjectModel.Helpers
{
    public static class ResourceHelpers
    {
        public static string GetString(string set, string key)
        {
            var typeName = "Resources." + set;
            var assembly = Assembly.Load("Resources");
            var manager = new System.Resources.ResourceManager(typeName, assembly);

            string ressourceText;

            try
            {
                ressourceText = manager.GetString(key, Thread.CurrentThread.CurrentUICulture);
            }
            catch (Exception)
            {
                throw;
            }

            if (ressourceText == null)
                throw new InvalidOperationException("Resource key does not exist in \'" + set + "\' resource set.");

            return ressourceText;
        }
    }
}
