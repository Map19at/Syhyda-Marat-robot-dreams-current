using System.Collections.Generic;
using UnityEngine;

public class Lection3Controller : MonoBehaviour
{
    [SerializeField] private List<int> numbers = new List<int>();
    [SerializeField] private int _number;

    [ContextMenu("Show List")]
    public void ShowList()
    {
        Debug.Log(numbers.Count == 0 ? "List is Empty" : string.Join(", ", numbers));
    }

    [ContextMenu("Add Number")]
    public void AddNumber()
    {
        numbers.Add(_number);
        Debug.Log("Number added: " + _number);
    }
    
    [ContextMenu("Add Random Number")]
    public void AddRandomNumber()
    {
        numbers.Add(Random.Range(0, 100));
        Debug.Log("Random number added: " + _number);
    }

    [ContextMenu("Remove Last")]
    public void RmoveLast()
    {
        numbers.Remove(_number);
        Debug.Log("Number removed: " + _number);
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
    
    
