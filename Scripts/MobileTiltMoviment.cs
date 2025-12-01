using UnityEngine;

public class MobileTiltMoviment : MonoBehaviour
{
    public float speed = 5f;
    public bool debugWithKeyboard = true;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

#if UNITY_EDITOR || UNITY_STANDALONE
        if (debugWithKeyboard)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            movement = new Vector3 (h, 0, v);
        }

        else
        {
            Vector3 tilt = Input.acceleration;
            movement = new Vector3(tilt.x, 0, tilt.y);
        }

#else
        Vector3 tilt = Input.acceleration;
        movement = new Vector3(tilt.x, 0, tilt.y);

#endif

        rb.AddForce(movement * speed);
    }
}
