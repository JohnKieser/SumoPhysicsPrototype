using UnityEngine;

public class rigidMover : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody _rb;
    public Vector3 _move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        movePlayer(_move);
    }
    void movePlayer(Vector3 dir)
    {
        _rb.AddForce(dir * speed);
    }
}
