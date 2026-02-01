using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject cutscene;

    public void StartCutScene()
    {
        cutscene.SetActive(true);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        Application.Quit();
    }
}