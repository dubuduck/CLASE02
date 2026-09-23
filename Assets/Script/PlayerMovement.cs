using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 5f;
    public float JumpForce = 10f;
    public Rigidbody oodi;
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
            oodi.AddForce(transform.forward * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.sKey.IsPressed())
        {
            oodi.AddForce(-transform.forward * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.aKey.IsPressed())
        {
            oodi.AddForce(-transform.right * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.dKey.IsPressed())
        {
            oodi.AddForce(transform.right * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        if (Keyboard.current.spaceKey.IsPressed()&&canJump)
        {
            oodi.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        }
    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
}
