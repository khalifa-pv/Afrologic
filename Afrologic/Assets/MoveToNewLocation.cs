using UnityEngine;

public class MoveToNewLocation : MonoBehaviour {
    Vector3 EndPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EndPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, EndPoint, 0.2f);
    }

    void NewPoint(Vector3 n)
    {
        EndPoint = n;
    }
}
