using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    Text text;

    private void Start()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }
    public void restart_game()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void see_your_result()
    {
        text.text = "Twój ostatni uzyskany wynik to " + Points.score;
    }
}
