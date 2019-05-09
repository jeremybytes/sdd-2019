using System;
using System.Collections.Generic;

namespace JeremyBytes.Library
{
    public class CachingClass
    {
        private DateTime dataDate;
        private List<string> cachedItems;

        public string DataTime
        {
            get { return dataDate.ToString("HH:mm:ss"); }
        }

        public List<string> CachedItems
        {
            get
            {
                if (cachedItems.Count == 0 || DateTime.UtcNow - dataDate > TimeSpan.FromSeconds(5))
                    RefreshCache();
                return cachedItems;
            }
        }

        public CachingClass()
        {
            cachedItems = new List<string>();
            RefreshCache();
        }

        private void RefreshCache()
        {
            dataDate = DateTime.UtcNow;
            cachedItems.Add(string.Format("Time: {0}", DataTime));
        }
    }
}
