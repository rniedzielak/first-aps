using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int score = 0;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        UpdateScore();
    }

    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        text.text = "Twój wynik to: " + score;
    }
}