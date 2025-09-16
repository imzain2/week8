using UnityEngine;

public class playerAttack : MonoBehaviour
{
    float power = 2.0f;
    private void OnTriggerStay2D(Collider2D touch)
    {
        if (touch.CompareTag("Coins"))
        {
            coinsHP hp = touch.GetComponent<coinsHP>();
            hp?.playertouch(power);
        }
    }
}

