using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  /// <summary> Interface for any object that can be cached for AssetObjects </summary>
  public interface IAssetCache { }

  /// <summary> A scriptable object capable of referencing a single cached data object, so it can keep runtime variables in memory to work with. </summary>
  /// <typeparam name="C"> Type of cached data </typeparam>
  public class AssetObject<C> : ScriptableObject where C : IAssetCache, new() {

    /// <summary> Cache of this asset object type </summary>
    private static Dictionary<AssetObject<C>, C> caches;

    /// <summary> Retrieves the cached data of this AssetObject </summary>
    public C cache {
      get {
        if (caches == null)
          caches = new Dictionary<AssetObject<C>, C>();

        if (caches.ContainsKey(this)) {
          return caches[this];
        }
        else {
          C c = new C();
          caches.Add(this, c);
					CacheSetup();
          return c;
        }
      }
    }
    
    /// <summary> Called when the cache has been accessed for the first time. </summary>
    protected virtual void CacheSetup() {

    }

  }
}