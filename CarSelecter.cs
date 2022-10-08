using UnityEngine;

public class CarSelecter : MonoBehaviour
{
    [SerializeField] private GameObject[] _menuCars;

    private static int _selectedCarIndex = 0;

    public static int SelectedCarIndex{ get => _selectedCarIndex; }

    private int _targetCarIndex = 0;

    public void NextCar() {
        if(_targetCarIndex < (_menuCars.Length - 1)) {
            _targetCarIndex++;
            UpdateVisibleCars();
        }
    }

    public void PreviousCar() {
        if(_targetCarIndex > 0) {
            _targetCarIndex--;
            UpdateVisibleCars();
        }
    }

    public void SelectCurrentcar() {
        _selectedCarIndex = _targetCarIndex;
        Debug.Log($"Selected car index: {_selectedCarIndex}");
        Menu.LoadNextScene();
    }

    public void UpdateVisibleCars() {
        for (int i = 0; i < _menuCars.Length; i++) {
            if (_menuCars[i] == _menuCars[_targetCarIndex]) {
                _menuCars[_targetCarIndex].SetActive(true);
                continue;
            }
            _menuCars[i].SetActive(false);
        }
    }
}
