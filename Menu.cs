using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private int _selectCarSceneIndex = 1;

    public void MoveToSelectCarScene() => SceneManager.LoadScene(_selectCarSceneIndex);

    public void MoreGames(string url) => Application.OpenURL(url);

    public static void LoadScene(int sceneIndex) => SceneManager.LoadScene(sceneIndex);

    public static void LoadNextScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
