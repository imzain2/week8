using UnityEngine;

public class coinsHP : MonoBehaviour
{
    void Start()
    {
        Chealth = health;
    }
    [SerializeField] private float Chealth;
    private float health = 1.0f;


    // Update is called once per frame
    public void playertouch(float e)
    {
        Chealth -= e;
        if (Chealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
