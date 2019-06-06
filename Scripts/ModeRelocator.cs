using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  /// <summary> Reads from an Int variable to determine what mode it is in, and moves itself to match target. </summary>
  public class ModeRelocator : MonoBehaviour {
		
    /// <summary> List of targets </summary>
    [Tooltip("The list of targets this relocator can move from and to.")]
    public List<Transform> targets;

    /// <summary> Current mode to use </summary>
    [Tooltip("The int value to use. Preferred to reference an IntVariable ScriptableObject.")]
    public IntReference mode;

    /// <summary> Speed to move position with. </summary>
    [Tooltip("The speed to use to move the position with.")]
    public LerpMoveValue positionSpeed;
    /// <summary> Speed to move rotation with. </summary>
    [Tooltip("The speed to use to move the rotation with.")]
    public LerpMoveValue rotationSpeed;
    /// <summary> Speed to move scale with. </summary>
    [Tooltip("The speed to use to move the scale with.")]
    public LerpMoveValue scaleSpeed;

    /// <summary> Whether it should ignore out of bounds indexes and keep last position </summary>
    [Tooltip("If true, any value falling outside of targets array bounds will be ignored. " +
      "Use this to keep the last position for invalid indexes instead of clamping and taking the closest possible target index.")]
    public bool ignoreOutOfBounds;
    /// <summary> Value the mode must be for it to match with target index 0. </summary>
    [Tooltip("The first valid value that can be used. The mode value set here will match with target index 0.")]
    public int modeStartValue;

    /// <summary> The mode to use </summary>
    protected int useMode;

    // Awaken and set to target immediatly.
    protected virtual void Awake() {
			useMode = Mathf.Clamp(mode.value, 0, targets.Count - 1);
      Transform target = targets[useMode];

			transform.position = target.position;
			transform.rotation = target.rotation;
			transform.localScale = target.localScale;
    }

    // Move self to target mode
    protected virtual void Update() {
      int modeValue = mode.value - modeStartValue;
      if (!ignoreOutOfBounds)
				useMode = Mathf.Clamp(modeValue, 0, targets.Count - 1);
      else if (modeValue >= 0 && modeValue < targets.Count)
				useMode = modeValue;

      Transform target = targets[useMode];
      Vector3 targetPos = target.position;
      Quaternion targetRot = target.rotation;
      Vector3 targetScale = target.localScale;

      if (transform.position != targetPos)
				transform.position = positionSpeed.Move(transform.position, targetPos);
      if (transform.rotation != targetRot)
				transform.rotation = rotationSpeed.Move(transform.localRotation, targetRot);
      if (transform.localScale != targetScale)
				transform.localScale = scaleSpeed.Move(transform.localScale, targetScale);
    }

  }
}