using UnityEngine;

public class MobileTiltMoviment : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;
        Vector3 movement = new Vector3(tilt.x, 0, tilt.y);

        rb.AddForce(movement * speed);
    }
}
