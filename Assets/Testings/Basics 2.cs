using System;
using Unity.VisualScripting;
using UnityEngine;

public class Basics2 : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake");
    }
    
    private void Start()
    {
        Debug.Log("Start");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    
}
