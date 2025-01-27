using System.Collections.Generic;
using UnityEngine;

public class CollectionsTest : MonoBehaviour
{
    [SerializeField] private int [] _integerArray;
    [SerializeField] private List<int> _integerList;

    [ContextMenu("Average")]
    public void Average()
    {
        int sum = 0;
        for (int i = 0; i < _integerArray.Length; ++i)
        {
            sum += _integerArray[i];
        }
        int average = sum / _integerArray.Length;
        Debug.Log($"Average for array: {average}");

        sum = 0;
        for (int i = 0; i < _integerList.Count; ++i)
        {
            sum += _integerArray[i];
        }
        average = sum / _integerList.Count;
        Debug.Log($"Average for list: {average}");
    }
}



