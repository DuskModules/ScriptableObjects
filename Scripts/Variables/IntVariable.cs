using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  [CreateAssetMenu(menuName = "DuskModules/Variable/IntVariable")]
  public class IntVariable : ScriptableObject {

		public event Action onChanged;

		[SerializeField]
		private int _value;
		public int value {
			get => _value;
			set {
				if (_value != value) {
					_value = value;
					onChanged?.Invoke();
				}
			}
		}

	}
}