using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject winUI;
    public GameObject loseUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winUI.SetActive(false);
        loseUI.SetActive(false);
    }

    public void Win()
    {
        winUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void Lose()
    {
        loseUI.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
