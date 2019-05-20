using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  [CreateAssetMenu(menuName = "DuskModules/Variable/StringVariable")]
  public class StringVariable : ScriptableObject {
    public string value;
  }

}