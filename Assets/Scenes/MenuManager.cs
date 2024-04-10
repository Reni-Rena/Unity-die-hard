using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private void Start()
    {
        ScoreText.text = Score.instance.scoreAmount.ToString();
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("SimplePoly City - Low Poly Assets_Demo Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
