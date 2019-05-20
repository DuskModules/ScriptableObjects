using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  /// <summary> Asset Instance Prefab is an Asset Instance that spawns a set prefab containing the required BehaviourInstance. </summary>
  public class AssetInstancePrefab<A, B> : AssetInstance<A,B> where A : AssetInstancePrefab<A, B> where B : BehaviourInstance<B, A> {

    /// <summary> Prefab to instantiate. </summary>
    public B prefab;

    /// <summary> Actually creates the BehaviourInstance. Can be modified by inheriting code. </summary>
    /// <returns> The scene BehaviourInstance </returns>
    protected override B InstantiateInstance() {
      return Instantiate(prefab);
    }

  }
}