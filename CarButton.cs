using UnityEngine.EventSystems;
using UnityEngine;

public class CarButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private int _pressedButtonCoefficient = 0;

    public int PressedButtonCoefficient{ get => _pressedButtonCoefficient; }

    public void OnPointerDown(PointerEventData data) => _pressedButtonCoefficient = 1;

    public void OnPointerUp(PointerEventData data) => _pressedButtonCoefficient = 0;
}
