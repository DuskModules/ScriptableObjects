using System;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

	[Serializable]
	public class ColorReference {
		public bool useConstant = true;
		public Color constant;
		public ColorVariable variable;

		public Color value {
			get => useConstant ? constant : variable.value;
			set {
				if (this.value != value) {
					if (useConstant) constant = value;
					else variable.value = value;
				}
			}
		}
	}

}
