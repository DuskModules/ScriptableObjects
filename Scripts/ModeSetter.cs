using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

	/// <summary> On enable of this element, a target mode is set to a different value. </summary>
	public class ModeSetter : MonoBehaviour {

    /// <summary> The asset to change the int value of </summary>
    [Tooltip("The int variable asset to set the int value to something else of, used as mode setting by moveable elements.")]
    public IntVariable modeAsset;

    /// <summary> The mode to set it to on enable </summary>
    [Tooltip("The int value to set the asset to on enable of this element.")]
    public int modeValue;

    // Enable
    private void OnEnable() {
			SetMode();
    }

    /// <summary> Sets the mode to the target </summary>
    public void SetMode() {
      if (modeAsset != null)
				modeAsset.value = modeValue;
    }

  }

}