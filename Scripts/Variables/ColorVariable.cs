using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  [CreateAssetMenu(menuName = "DuskModules/Variable/ColorVariable")]
  public class ColorVariable : ScriptableObject {
    public Color value;
  }

}