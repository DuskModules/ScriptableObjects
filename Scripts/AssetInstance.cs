using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {
  
  /// <summary> Asset Instance is a scriptable object which is linked to a BehaviourInstance in the scene.
  /// By calling the AssetInstance within the AssetDatabase, code can find the scene instance belonging to it and call upon it's code. </summary>
  public class AssetInstance<A, B> : ScriptableObject where A : AssetInstance<A, B> where B : BehaviourInstance<B, A> {

    /// <summary> Dictionary of all auto instances. Key = prefab, value = instance of that prefab. </summary>
    protected static Dictionary<A, B> _instances;
    /// <summary> Dictionary of all auto instances. Key = prefab, value = instance of that prefab. </summary>
    public static Dictionary<A, B> instances {
      get {
        if (_instances == null) _instances = new Dictionary<A, B>();
        return _instances;
      }
    }

    /// <summary> Upon getting the instance </summary>
    public B instance => CreateInstance();

    /// <summary> Locates or creates the instance </summary>
    public B CreateInstance() {
      B instance = null;
      A self = (A)this;
      if (instances.ContainsKey(self)) {
        instance = instances[self];
        if (instance == null || instance.gameObject == null) instances.Remove(self);
        else return instance;
      }

      // Not present within dictionary, find or create it.
      instance = GetSceneInstance();
      if (instance == null)
        instance = CreateSceneInstance();

      if (instance != null)
        instances.Add(self, instance);

      return instance;
    }
    
    /// <summary> Finds and returns the BehaviourInstance present in the scene </summary>
    /// <returns> The scene BehaviourInstance </returns>
    protected B GetSceneInstance() {
      B[] foundInstances = FindObjectsOfType<B>();
      for (int i = 0; i < foundInstances.Length; i++) {
        if (foundInstances[i].asset == this) {
          return foundInstances[i];
        }
      }
      return null;
    }

    /// <summary> Creates a new BehaviourInstance within the current scene </summary>
    /// <returns> The scene BehaviourInstance </returns>
    protected B CreateSceneInstance() {
      if (CreationAllowed()) {
        B instance = InstantiateInstance();
        instance.SetAsset((A)this);
        return instance;
      }
      return null;
    }

    /// <summary> Actually creates the BehaviourInstance. Can be modified by inheriting code. </summary>
    /// <returns> The scene BehaviourInstance </returns>
    protected virtual B InstantiateInstance() {
      GameObject createdObject = new GameObject(name);
      return createdObject.AddComponent<B>();
    }

    /// <summary> Called when the instance has been destroyed. </summary>
    /// <param name="instance"> The instance to remove </param>
    public void Remove(B removeInstance) {
      if (instance == removeInstance) {
        instances.Remove((A)this);
      }
    }

    /// <summary> Whether creation is allowed. If it returns true, a new instance is created if none is found. </summary>
    /// <returns> Whether creation is allowed. </returns>
    protected virtual bool CreationAllowed() { return true; }

  }
}