using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _panelWin;
    [SerializeField] private GameObject _panelLose;

    public void Win()
    {
        _panelWin.SetActive(true);
        GAManager.instance.OnLevelComlete(SceneManager.GetActiveScene().buildIndex);
    }

    public void Lose()
    {
        _panelLose.SetActive(true);
        GAManager.instance.OnLevelFailed(SceneManager.GetActiveScene().buildIndex);
    }

    public void TryAgain()
    {
        GAManager.instance.OnLevelButtonTryAgain(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(0);
    }
}
