using UnityEngine;

public class Pooling : MonoBehaviour
{
    Vector3 position;
    Rigidbody2D rb;
    void Start()
    {
        position = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    public void StartOver()
    {
        ResetOrientation();
        transform.position = position;

    }
    public void ResetOrientation()
    {
        transform.rotation = Quaternion.identity;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0;
    }
}
