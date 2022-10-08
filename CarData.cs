using UnityEngine;

public class CarData : MonoBehaviour
{
    [SerializeField] private WheelCollider[] _invisibleWheels, _forwardInvisibleWheels;

    public WheelCollider[] InvisibleWheels{ get => _invisibleWheels; }
    
    public WheelCollider[] ForwardInvisibleWheels{ get => _forwardInvisibleWheels; }

    [SerializeField] private Transform[] _visibleWheels;

    public Transform[] VisibleWheels{ get => _visibleWheels; }

    [SerializeField] private float _maxEngineTorque, _maxBrakeTorque, _maxSteerAngle;

    public float MaxEngineTorque{ get => _maxEngineTorque; }

    public float MaxBrakeTorque{ get => _maxBrakeTorque; }

    public float MaxSteerAngle{ get => _maxSteerAngle; }

    [SerializeField] private CarButton _gasButton, _brakeButton, _backwardsButton;

    public CarButton GasButton{ get => _gasButton; }

    public CarButton BrakeButton{ get => _brakeButton; }

    public CarButton BackwardsButton{ get => _backwardsButton; }

    [SerializeField] private float _centerOfMass = -0.9f;

    private Rigidbody _rigidbody;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = new Vector3(0, _centerOfMass, 0);
    }
}
