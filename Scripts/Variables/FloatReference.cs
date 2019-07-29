using System;

namespace DuskModules.ScriptableObjects {

	[Serializable]
	public class FloatReference {
		public bool useConstant = true;
		public float constant;
		public FloatVariable variable;

		public float value {
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