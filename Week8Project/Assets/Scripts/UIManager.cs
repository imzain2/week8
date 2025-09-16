using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] private ScoreKeeper scoreKeeper;
    [SerializeField] private TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("Score: {0}", scoreKeeper.CurrentScore);
    }
}
