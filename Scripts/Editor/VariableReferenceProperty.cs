using UnityEditor;
using UnityEngine;

namespace DuskModules.ScriptableObjects.DuskEditor {

	/// <summary> Custom property drawer for the float reference field </summary>
	[CustomPropertyDrawer(typeof(ColorReference))]
	public class ColorReferenceProperty : BaseReferenceProperty {

	}

	/// <summary> Custom property drawer for the float reference field </summary>
	[CustomPropertyDrawer(typeof(FloatReference))]
	public class FloatReferenceProperty : BaseReferenceProperty {

	}

	/// <summary> Custom property drawer for the float reference field </summary>
	[CustomPropertyDrawer(typeof(IntReference))]
	public class IntReferenceProperty : BaseReferenceProperty {

	}

	/// <summary> Custom property drawer for the float reference field </summary>
	[CustomPropertyDrawer(typeof(StringReference))]
	public class StringReferenceProperty : BaseReferenceProperty {

	}

}