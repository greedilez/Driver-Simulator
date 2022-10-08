using UnityEngine;

public class CarSynchronizer : MonoBehaviour
{
    private CarData _carData;

    private void Awake() => _carData = GetComponent<CarData>();

    private void FixedUpdate() => SynchronizeAllWheels();

    public void SynchronizeAllWheels() {
        for (int i = 0; i < _carData.InvisibleWheels.Length; i++) {
            Vector3 pos;
            Quaternion rot;
            _carData.InvisibleWheels[i].GetWorldPose(out pos, out rot);
            _carData.VisibleWheels[i].position = pos;
            _carData.VisibleWheels[i].rotation = rot;
        }
    }
}
