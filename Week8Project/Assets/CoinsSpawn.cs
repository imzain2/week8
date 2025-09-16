using UnityEngine;

public class CoinsSpawn : MonoBehaviour
{
    [SerializeField] private GameObject coins;
    [SerializeField] private float spawnTime = 1f;
    private float timer;
    void Start()
    {
        timer = spawnTime;
        random();
    }
    private Vector2 randomy;
    public void random()
    {
        float x = Random.Range(-8, 8);
        float y = Random.Range(-4, 4);
        randomy = new Vector2(x, y);
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            random();
            Instantiate(coins, randomy, Quaternion.identity);
            timer = spawnTime;
        }
    }
}
