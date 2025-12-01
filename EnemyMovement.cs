using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 2f;
    public float distance = 3f;

    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        StartCoroutine(MoveLoop());
    }

    System.Collections.IEnumerator MoveLoop()
    {
        while (true)
        {
            yield return MoveTo(startPos + Vector3.right * distance);
            yield return MoveTo(startPos);
        }
    }

    System.Collections.IEnumerator MoveTo(Vector3 target)
    {
        while (Vector3.Distance(transform.position, target) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            yield return null;
        }
    }
}
