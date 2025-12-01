using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 5f;

    public Text text;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        Invoke("EnablePhysics", 0.5f);
    }

    void EnablePhysics()
    {
        rb.isKinematic = false;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(Input.acceleration.x * speed, 0, Input.acceleration.y * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projetil"))
        {
            text.text = "Game Over!";
            speed = 0;
            Invoke("ReloadScene", 2f);
        }

        if (other.CompareTag("WinTrigger"))
        {
            text.text = "You Win!";
            speed = 0;
            Invoke("ReloadScene", 2f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
