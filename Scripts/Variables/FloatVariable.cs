using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

	[CreateAssetMenu(menuName = "DuskModules/Variable/FloatVariable")]
	public class FloatVariable : ScriptableObject {

		public event Action onChanged;

		[SerializeField]
		private float _value;
		public float value {
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