using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    [SerializeField] private string titleSceneName = "Title";

    public void ReturnToTitle()
    {
        SceneManager.LoadScene(titleSceneName);
    }
}
