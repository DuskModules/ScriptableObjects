using UnityEditor;
using UnityEngine;

namespace DuskModules.ScriptableObjects.DuskEditor {

  /// <summary> Custom property drawer for the any variable reference field </summary>
  public class BaseReferenceProperty : BoolToggleProperty {

    /// <summary> Name for option to show for boolean false </summary>
    public override string GetBoolFalseName() {
      return "Variable";
    }

    /// <summary> Draw GUI if boolean is true </summary>
    public override void DrawTrueGUI(SerializedProperty property) {
      ExtraEditorUtility.TakeSpace();
      ExtraEditorUtility.PropertyField(property.FindPropertyRelative("constant"));
    }

    /// <summary> Draw GUI if boolean is false </summary>
    public override void DrawFalseGUI(SerializedProperty property) {
      ExtraEditorUtility.TakeSpace();
      ExtraEditorUtility.PropertyField(property.FindPropertyRelative("variable"));
    }
  }
}