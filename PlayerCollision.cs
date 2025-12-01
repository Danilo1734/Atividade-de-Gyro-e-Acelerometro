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
}
