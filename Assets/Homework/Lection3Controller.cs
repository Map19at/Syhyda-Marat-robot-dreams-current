using System.Collections.Generic;
using UnityEngine;

public class Lection3Controller : MonoBehaviour
{
    [SerializeField] private int _value;

    [SerializeField] private List<int> _list;

    [ContextMenu("Print")]
    public void Print()
    {
        if (_list == null || _list.Count == 0)
        {
            Debug.Log("List is empty");
            return;
        }

        string msg = string.Join(", ", _list);
        Debug.Log("List: " + msg);
    }

    [ContextMenu("Remove Last Element")]
    public void RemoveLastElement()
    {
        if (_list != null && _list.Count > 0)
        {
            _list.RemoveAt(_list.Count - 1);
            Debug.Log("Last element removed");
        }
        else
        {
            Debug.Log("List is empty, nothing to remove.");
        }
    }
}
    
    
