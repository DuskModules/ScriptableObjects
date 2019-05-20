using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  /// <summary> Interface for any monobehaviour that can be linked to the AssetInstance </summary>
  public class BehaviourInstance<A, B> : MonoBehaviour where A : BehaviourInstance<A, B> where B : AssetInstance<B, A> {

		/// <summary> Asset this behaviour instance is the instance of. </summary>
		public B asset => _asset;
		[SerializeField]
		private B _asset;
    
    // Awake to check if there are no duplicates
    protected virtual void Awake() {
      if (asset != null) {
        if (asset.instance != this) {
          Debug.LogWarning("Warning! " + gameObject.name + " is linked to asset " + asset.name + ", which has a different instance! " +
            "There should only be one active BehaviourInstance per AssetInstance in the game.");
        }
      }
    }

    /// <summary> Sets the asset this behaviour belongs to. </summary>
    /// <param name="asset"> Asset to set </param>
    public virtual void SetAsset(B asset) {
			_asset = asset;
    }

    // Removes from dictionary
    protected virtual void OnDestroy() {
      if (asset != null)
				asset.Remove((A)this);
    }
  }
}