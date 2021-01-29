using System;
using System.Collections.Generic;

namespace astronomy_11625
{
    class DataStore
    {
        public delegate void SpaceObjectsEventHandler();
        public static event SpaceObjectsEventHandler SpaceObjectsChanged;
        public static List<SpaceObject> SpaceObjects { get; }
        public static List<Measurement> Measurements { get; }
        static DataStore()
        {
            SpaceObjects = new List<SpaceObject>();
            Measurements = new List<Measurement>();      
        }
        public static void LoadSpaceObjects()
        {
            CSV_Entity.ReadSpaceObjects();
        }
        public static void AddToSpaceObjects(SpaceObject so)
        {
            if (!SpaceObjects.Exists(x => x.Name == so.Name))
            {
                SpaceObjects.Add(so);
                OnSpaceObjectsItemsChanged();
            }
        }
        public static void OnSpaceObjectsItemsChanged()
        {
            SpaceObjectsChanged?.Invoke();
        }

        internal static void RemoveFromSpaceObjects(SpaceObject selected)
        {
            if (SpaceObjects.Exists(x => x.Name == selected.Name))
            {
                SpaceObjects.Remove(selected);
                OnSpaceObjectsItemsChanged();
            }
        }
    }
}
