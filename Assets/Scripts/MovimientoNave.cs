using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoNave : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public float rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.aKey.isPressed)
        {
            transform.localEulerAngles = transform.localEulerAngles
                + new Vector3(0, 0, 1) * rotation * Time.deltaTime;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.localEulerAngles = transform.localEulerAngles
                + new Vector3(0, 0, -1) * rotation * Time.deltaTime;
        }
        Debug.Log(transform.up);
        if (Keyboard.current.wKey.isPressed)
        {
            rb.AddForce(transform.up * force * Time.deltaTime);
        }
    }
}
