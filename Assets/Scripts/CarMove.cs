using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 10f;
    public float maxDistance = 100f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Vector3.Distance(startPos, transform.position) > maxDistance)
        {
            transform.position = startPos;
        }
    }
}