using System;
using UnityEngine;

public class LightProbe : MonoBehaviour
{
    [SerializeField] private LightProbeGroup lightProbeGroup;
    [SerializeField] private Vector3 _extends;
    [SerializeField] private Vector3Int _resolution;

    [ContextMenu("Generate Grid")]
    private void GenerateGrid()
    {
        Vector3Int subResolution =_resolution - Vector3Int.one;
        
        int mainGridCount = _resolution.x * _resolution.y * _resolution.z;

        Vector3[] probes = new Vector3[mainGridCount +
                                       subResolution.x * subResolution.y * subResolution.z];
        
        Vector3 offset = _extends * 0.5f;
        Vector3 spacing;
        spacing.x = _extends.x / (_resolution.x - 1);
        spacing.y = _extends.y / (_resolution.y - 1);
        spacing.z = _extends.z / (_resolution.z - 1);

        for (int x = 0; x < _resolution.x; ++x)
        {
            for (int y = 0; y < _resolution.y; ++y)
            {
                for (int z = 0; z < _resolution.z; ++z)
                {
                    Vector3 position = new Vector3(x * spacing.x, y * spacing.y, z * spacing.z) - offset;
                    int index = x + y * _resolution.x + z * _resolution.y * _resolution.x;
                    probes[index] = position;
                }
            }
        }
        
        Vector3 subExtents = _extends - spacing;
        Vector3 subOffest = subExtents * 0.5f;

        for (int x = 0; x < _resolution.x; ++x)
        {
            for (int y = 0; y < _resolution.y; ++y)
            {
                for (int z = 0; z < _resolution.z; ++z)
                {
                    Vector3 position = new Vector3(x * spacing.x, y * spacing.y, z * spacing.z) - subOffest;
                    int index = x + y * subResolution.x + z * subResolution.y * subResolution.x + mainGridCount;
                    probes[index] = position;
                }
            }
        } 
        
        lightProbeGroup.probePositions = probes;
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, _extends);
    }
}
