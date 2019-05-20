using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  /// <summary> A runtime set contains a list of items that add themselves on runtime, to more easily keep track of all. </summary>
  public class RuntimeSet<T> : ScriptableObject {

    /// <summary> Item to add </summary>
    public List<T> items;

    /// <summary> Adds an item </summary>
    public void Add(T t) {
      if (!items.Contains(t)) items.Add(t);
    }
    /// <summary> Removes an item </summary>
    public void Remove(T t) {
      if (items.Contains(t)) items.Remove(t);
    }

  }
}