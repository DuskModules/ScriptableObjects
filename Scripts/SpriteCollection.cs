using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  /// <summary> Collection of sprites to get random from. </summary>
  [CreateAssetMenu(menuName = "DuskModules/SpriteCollection")]
  public class SpriteCollection : ScriptableObject {
		
		/// <summary> A List of Sprites </summary>
		public List<Sprite> collection => _collection;
		[Header("Sprites")]
		[SerializeField]
		protected List<Sprite> _collection;

	}
}