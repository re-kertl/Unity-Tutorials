using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int count;
    public Canvas canvas;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        canvas.transform.position = new Vector3(transform.position.x, canvas.transform.position.y, transform.position.z);
    }

    // will get called when player touches Trigger Collider, destroy: all components and children (Destroy(other.gameObject);)
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }

    }
}
