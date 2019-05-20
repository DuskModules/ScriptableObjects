using System;

namespace DuskModules.ScriptableObjects {

  [Serializable]
  public class IntReference {
    public bool useConstant = true;
    public int constant;
    public IntVariable variable;

    public int value => useConstant ? constant : variable.value;
  }

}