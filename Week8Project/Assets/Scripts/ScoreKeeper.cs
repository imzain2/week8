using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int currentScore;
    public int CurrentScore
    {
        get
        {
            return currentScore;
        }
    }
    void Start()
    {
        currentScore = 0;
    }

    public void OnPickup(int score)
    {
        currentScore += score;
    }
}
