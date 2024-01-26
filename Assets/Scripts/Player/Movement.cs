using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 10.0f;
    public static float rotation = 1.0f;
    private Rigidbody rb;

    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if(Input.GetKey(KeyCode.LeftShift)){
            velocity = 10.0f;
        }else{
            velocity = 5.0f;
        }

        Vector3 dir = new Vector3(x, 0, y) * velocity;

        transform.Translate(dir * Time.deltaTime);

        transform.Rotate(new Vector3(0f, mouseX, 0f));
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Parede")
        {
            rb.AddForce(Vector3.back*1);
        }
    }
}
