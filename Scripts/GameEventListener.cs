using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DuskModules.ScriptableObjects {

  /// <summary> Listens to the target event and fires an Unity event </summary>
  public class GameEventListener : MonoBehaviour {

    /// <summary> Game event to listen for </summary>
    public GameEvent gameEvent;
    /// <summary> Response to fire upon game event fire </summary>
    public UnityEvent response;

    // Register
    private void OnEnable() {
			gameEvent.RegisterCallback(FireResponse);
    }
    // Unregister
    private void OnDisable() {
			gameEvent.UnregisterCallback(FireResponse);
    }

    /// <summary> Fire UnityEvent </summary>
    public void FireResponse() {
			response.Invoke();
    }
  }
}