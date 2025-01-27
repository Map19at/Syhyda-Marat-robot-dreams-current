using System.Collections.Generic;
using UnityEngine;

public class Lection3Controller : MonoBehaviour
{
  [SerializeField] private int _value;
  
  [SerializeField] private List<int> _list;
  
  [ContextMenu("Print")]
  private void Print()
  {
    string msg = "List: ";
    for (int i = 0; i < _list.Count; i++)
      msg += "\n" + _list[i];
    Debug.Log(msg);
    _list.RemoveAt(_list.Count - 1);
  }
}
