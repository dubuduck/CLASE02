using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 10f;
    public float JumpForce = 15f;
    public Rigidbody AmongUs;

    bool canJump = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.wKey.IsPressed())
        {
            AmongUs.AddForce(Vector3.forward * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.sKey.IsPressed())
        {
            AmongUs.AddForce(Vector3.back * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.aKey.IsPressed())
        {
            AmongUs.AddForce(Vector3.left * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.dKey.IsPressed())
        {
            AmongUs.AddForce(Vector3.right * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
    }
}
