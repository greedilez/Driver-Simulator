using UnityEngine.EventSystems;
using UnityEngine;

public class SteerArrow : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private static float _horizontal = 0;

    public static float HorizontalAxis{ get => _horizontal; set => _horizontal = value; }

    [SerializeField] private float _currentButtonValue = 1;

    public void OnPointerUp(PointerEventData data) => HorizontalAxis = 0;

    public void OnPointerDown(PointerEventData data) => HorizontalAxis = _currentButtonValue;
}
