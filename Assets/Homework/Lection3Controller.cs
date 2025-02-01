using System.Collections.Generic;
using UnityEngine;

public class Lection3Controller : MonoBehaviour
{
    [SerializeField] private List<int> numbers = new List<int>();

    [ContextMenu("Show List")]
    public void ShowList()
    {
        Debug.Log(numbers.Count == 0 ? "List is Empty" : string.Join(", ", numbers));
    }

    [ContextMenu("Add Number")]
    public void AddNumber()
    {
        numbers.Add(Random.Range(0, 100));
        Debug.Log("Number added");
    }

    [ContextMenu("Remove Last")]
    public void RemoveLast()
    {
        if (numbers.Count > 0) numbers.RemoveAt(numbers.Count - 1);
        Debug.Log("Number removed");
    }

    [ContextMenu("Clear List")]
    public void ClearList()
    {
        numbers.Clear();
        Debug.Log("List is empty");
    }

    [ContextMenu("Sort List")]
    public void SortList()
    {
        numbers.Sort();
        Debug.Log("List is sorted");
    }
}
    
    
