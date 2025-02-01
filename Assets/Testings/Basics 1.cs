using UnityEngine;
using System;
using System.Collections.Generic;

public class Basics1 : MonoBehaviour
{
    public int _num = 6;
    public string _word;
    [SerializeField] public float _nums;
    
    public int[] numbers = new int[3];
    
    public List<string> words = new List<string>();
    
    void Start()
    {
        if(_num != 5)
        Debug.Log(_word + _nums);
    }
    
}



