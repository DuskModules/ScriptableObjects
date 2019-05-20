using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  /// <summary> Game event can be called, any listeners then fire. </summary>
  [CreateAssetMenu(menuName = "DuskModules/GameEvent")]
  public class GameEvent : ScriptableObject {

    /// <summary> Action to be called and hooked into </summary>
    public event Action onEventTrigger = delegate { };

    /// <summary> Registers the given callback to the game event </summary>
    /// <param name="callback"> What method to call upon fire </param>
    public void RegisterCallback(Action callback) {
      onEventTrigger += callback;
    }
    /// <summary> Unregisters the given callback to the game event </summary>
    /// <param name="callback"> What method to no longer call upon fire </param>
    public void UnregisterCallback(Action callback) {
      onEventTrigger -= callback;
    }

    /// <summary> Called when event should fire. </summary>
    public void FireEvent() {
      onEventTrigger();
    }
  }
}