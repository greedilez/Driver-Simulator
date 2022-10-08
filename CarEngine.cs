using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngine : MonoBehaviour
{
    private CarData _carData;

    private void Awake() => _carData = GetComponent<CarData>();

    private void FixedUpdate() {
        AddTorqueToWheels();
        AddBackwardsTorqueToWheels();
        AddBrakeToWheels();
    }

    public void AddTorqueToWheels() {
        for (int i = 0; i < _carData.InvisibleWheels.Length; i++) {
            _carData.InvisibleWheels[i].motorTorque = _carData.MaxEngineTorque * _carData.GasButton.PressedButtonCoefficient;
        }
    }

    public void AddBackwardsTorqueToWheels() {
        if(_carData.BackwardsButton.PressedButtonCoefficient != 0) {
            for (int i = 0; i < _carData.InvisibleWheels.Length; i++) {
                _carData.InvisibleWheels[i].motorTorque = -_carData.MaxEngineTorque * _carData.BackwardsButton.PressedButtonCoefficient;
            }
        }
    }

    public void AddBrakeToWheels() {
        for (int i = 0; i < _carData.InvisibleWheels.Length; i++) {
            _carData.InvisibleWheels[i].brakeTorque = _carData.MaxBrakeTorque * _carData.BrakeButton.PressedButtonCoefficient;
        }
    }
}
