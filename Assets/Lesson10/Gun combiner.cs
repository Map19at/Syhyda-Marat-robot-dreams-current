using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Lesson10
{
    public class Guncombiner : MonoBehaviour
    {
        [SerializeField] private MeshFilter[] _meshFilters;

        private Mesh _mesh;

        [ContextMenu("Generate Gun Mesh")]
        private void GenerateGunMesh()
        {
            _mesh = new Mesh();
            
            Matrix4x4 objjectMatrix = transform.worldToLocalMatrix;
            CombineInstance[] instances = new CombineInstance[_meshFilters.Length];

            for (int i = 0; i < _meshFilters.Length; ++i)
            {
                CombineInstance instance = new CombineInstance();
                instance.mesh = _meshFilters[i].sharedMesh;
                instance.transform = objjectMatrix * _meshFilters[i].transform.localToWorldMatrix;
                instances[i] = instance;
            }
            
            _mesh.CombineMeshes(instances, false, true);

#if UNITY_EDITOR
            string path = EditorUtility.SaveFilePanelInProject("Save Gun Mesh", "New Gun Mesh", "asset", "");
            AssetDatabase.CreateAsset(_mesh, path);
#endif
        }
    }
}


