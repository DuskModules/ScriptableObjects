using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DuskModules.ScriptableObjects.DuskEditor {

  /// <summary> Editor for game event </summary>
  [CustomEditor(typeof(GameEvent))]
  [CanEditMultipleObjects]
  public class GameEventEditor : Editor {

    /// <summary> Inspector GUI </summary>
    public override void OnInspectorGUI() {
      base.OnInspectorGUI();

      if (GUILayout.Button("Fire Event")) {
        GameEvent gameEvent = (GameEvent)target;
        gameEvent.FireEvent();
      }
    }
  }
}