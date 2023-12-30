using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBucket(); // Call the function to move the bucket in the Update
    }

    void MoveBucket()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalMovement, 0f, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }

    // Function to change the speed of the bucket
    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
