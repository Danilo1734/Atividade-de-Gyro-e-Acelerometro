using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public Rigidbody projetil;

    public float hSpeed, vSpeed;

    public float fireRate;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= fireRate)
        {
            Rigidbody tempProjetil = Instantiate(projetil, transform.position, Quaternion.identity);
            tempProjetil.linearVelocity = new Vector3(hSpeed, 0, vSpeed);
            timer = 0;
        }
    }
}
