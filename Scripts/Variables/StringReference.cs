using System;

namespace DuskModules.ScriptableObjects {

	[Serializable]
	public class StringReference {
		public bool useConstant = true;
		public string constant;
		public StringVariable variable;

		public string value {
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