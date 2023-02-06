using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScoreField;
    // Start is called before the first frame update
    void Start()
    {
        SetBestScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetBestScore()
    {
        if (ScoreManager.Instance != null && ScoreManager.Instance.bestScore > 0)
        {
            bestScoreField.text = "Best Score: " + ScoreManager.Instance.bestScoreName + " : " + ScoreManager.Instance.bestScore;
        }
    }
}
