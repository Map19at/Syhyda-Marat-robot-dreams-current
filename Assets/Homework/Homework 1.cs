using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
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

        string msg = "List: ";
        for (int i = 0; i < _list.Count; ++i)
        {
            msg += $"\n{_list[i]}";
        }

        _value = _list[_list.Count - 1];
        _list.RemoveAt(_list.Count - 1);

        Debug.Log(msg);
    }
}