using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyByContact : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }
}
