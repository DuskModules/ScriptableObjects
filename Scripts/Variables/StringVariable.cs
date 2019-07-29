using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

	[CreateAssetMenu(menuName = "DuskModules/Variable/StringVariable")]
	public class StringVariable : ScriptableObject {

		public event Action onChanged;

		[SerializeField]
		private string _value;
		public string value {
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