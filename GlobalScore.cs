using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{

    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreText;

    // Update is called once per frame
    void Update()
    {
        InternalScore = CurrentScore;
        ScoreText.GetComponent<Text>().text = "" + InternalScore;
    }
}
