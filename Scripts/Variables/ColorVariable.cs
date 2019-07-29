using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

	[CreateAssetMenu(menuName = "DuskModules/Variable/ColorVariable")]
	public class ColorVariable : ScriptableObject {

		public event Action onChanged;

		[SerializeField]
		private Color _value;
		public Color value {
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