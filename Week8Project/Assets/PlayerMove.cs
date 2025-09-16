using UnityEngine;
using static UnityEngine.InputSystem.DefaultInputActions;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float speed = 5f;
    private PlayerAction actions;
    private InputAction move;
    private void Awake()
    {
        actions = new PlayerAction();
        move = actions.player.movement;
    }
    private void OnEnable()
    {
        move.Enable();
    }
    private void OnDisable()
    {
        move.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        float updown = move.ReadValue<Vector2>().y;
        float lr = move.ReadValue<Vector2>().x;
        if (updown > 0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.Self);

        }
        else if (updown < 0)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
        }
        else if (lr > 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }
        else if (lr < 0)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
        }
    }

}
