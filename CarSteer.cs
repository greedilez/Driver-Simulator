using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteer : MonoBehaviour
{
    private CarData _carData;

    private void Awake() => _carData = GetComponent<CarData>();

    private void FixedUpdate() => AddSteerToWheels();

    public void AddSteerToWheels() {
        for (int i = 0; i < _carData.ForwardInvisibleWheels.Length; i++) {
            _carData.ForwardInvisibleWheels[i].steerAngle = _carData.MaxSteerAngle * SteerArrow.HorizontalAxis;
        }   
    }
}
