using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _carPrefabs;

    private void Awake() => SpawnCar(CarSelecter.SelectedCarIndex, _carPrefabs);

    public void SpawnCar(int carIndex, GameObject[] carPrefabs) => Instantiate(carPrefabs[carIndex], transform.position, Quaternion.identity);
}
