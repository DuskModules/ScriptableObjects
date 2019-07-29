using System;

namespace DuskModules.ScriptableObjects {

	[Serializable]
	public class IntReference {
		public bool useConstant = true;
		public int constant;
		public IntVariable variable;

		public int value {
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