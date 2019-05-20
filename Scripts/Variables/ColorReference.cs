using System;
using UnityEngine;

namespace DuskModules.ScriptableObjects {

  [Serializable]
  public class ColorReference {
    public bool useConstant = true;
    public Color constant;
    public ColorVariable variable;

    public Color value => useConstant ? constant : variable.value;
  }

}