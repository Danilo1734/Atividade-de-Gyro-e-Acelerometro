using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameController gameController;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            gameController.Lose();
        }

        if (other.CompareTag("Goal"))
        {
            gameController.Win();
        }
    }

    void LateUpdate()
    {
       Vector3 pos = transform.position;
        
        pos.x = Mathf.Clamp(pos.x, 0, 0);
        pos.z = Mathf.Clamp(pos.z, 0, 0);

        transform.position = pos;
    }
}
