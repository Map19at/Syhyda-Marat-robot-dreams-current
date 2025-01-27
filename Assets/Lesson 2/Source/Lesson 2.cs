using UnityEngine;

public class Lesson2 : MonoBehaviour
{
  [SerializeField] private int _firstIntegerNumber;
  [SerializeField] private int _secondIntegerNumber;
  [SerializeField] private float _firstFloatNumber;
  [SerializeField] private string _firstText;
  [SerializeField] private MyVector3 _firstVector;
  [SerializeField] private ColorSwatch _colorSwatch;
  
  private float _hiddenNumber;

  [ContextMenu("Hello Mapat")]
  private void HelloWorld()
  {
    Debug.Log("Hello Mapat");
    Debug.Log("Hello Marat");
  }

  [ContextMenu("Add")]
  private void Add()
  {
    int result = _firstIntegerNumber + _secondIntegerNumber;
    Debug.Log(result);
  }
}  
    

