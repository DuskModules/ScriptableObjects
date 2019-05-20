using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  [CreateAssetMenu(menuName = "DuskModules/Variable/IntVariable")]
  public class IntVariable : ScriptableObject {
    public int value;
  }

}