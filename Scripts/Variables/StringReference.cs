using System;

namespace DuskModules.ScriptableObjects {

  [Serializable]
  public class StringReference {
    public bool useConstant = true;
    public string constant;
    public StringVariable variable;

    public string value => useConstant ? constant : variable.value;
  }

}