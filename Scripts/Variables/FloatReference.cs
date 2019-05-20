using System;

namespace DuskModules.ScriptableObjects {

  [Serializable]
  public class FloatReference {
    public bool useConstant = true;
    public float constant;
    public FloatVariable variable;

    public float value => useConstant ? constant : variable.value;
  }

}