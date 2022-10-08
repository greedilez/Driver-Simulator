using UnityEngine;

public class Deformation : MonoBehaviour {

    [SerializeField] private MeshFilter[] _meshFilters;

    [SerializeField] private MeshCollider _meshCollider;

    [SerializeField] private float _maxDamageDistance = 0.5f;

    [SerializeField] private float _damageCoefficient = 1f;

    [SerializeField] private bool _recalculateMeshCollider = false;

    private void Start() {
        for (int i = 0; i < _meshFilters.Length; i++) _meshFilters[i].mesh.MarkDynamic();
    }

    private void OnCollisionEnter(Collision collision) {
        Vector3 localContactPoint = transform.InverseTransformPoint(collision.contacts[0].point);
        Vector3 localForce = transform.InverseTransformDirection(collision.relativeVelocity * 0.025f);
        for (int i = 0; i < _meshFilters.Length; i++) Deformate(collision, localContactPoint, localForce, _meshFilters[i]);
    }

    public void Deformate(Collision collision, Vector3 localContactPoint, Vector3 localForce, MeshFilter meshFilter) {
        Vector3[] targetVertices = meshFilter.mesh.vertices;
        for (int i = 0; i < targetVertices.Length; i++) {
            float distance = (localContactPoint - targetVertices[i]).magnitude;
            if (distance <= _maxDamageDistance) {
                targetVertices[i] += localForce * (_maxDamageDistance - distance) * _damageCoefficient;
            }
        }
        meshFilter.mesh.vertices = targetVertices;
        if (_recalculateMeshCollider) _meshCollider.sharedMesh = meshFilter.mesh;
        RecalculateMesh(meshFilter);
    }

    public void RecalculateMesh(MeshFilter meshFilter) {
        meshFilter.mesh.RecalculateNormals();
        meshFilter.mesh.RecalculateBounds();
    }
}
