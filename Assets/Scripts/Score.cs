using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMesh score;
    public int count;

    void Start()
    {
        //Here, count calls highscore value at Scene03
        count = PlayerPrefs.GetInt("highscore");
        score.text = count.ToString();

    }
    void Update()
    {
        //Score values are counting.
        score.text = count.ToString();

        //Highscore value sets as count at the beginning
        PlayerPrefs.SetInt("highscore", count);
        score.text = count.ToString();

    }

}
