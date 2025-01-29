using UnityEngine;

public class Operations : MonoBehaviour
{
    [SerializeField] private Transform _first;
    [SerializeField] private Transform _second;
    [SerializeField] private float _range;

    [ContextMenu("Is In Range")]
    private void InRange()
    {
        Vector3 difference = _first.position - _second.position;
        float distance = difference.magnitude;
        Debug.Log(distance <= _range ? "Is In Range" : "Is Not In Range");
    }
}
