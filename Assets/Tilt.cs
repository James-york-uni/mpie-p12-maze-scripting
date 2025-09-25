using UnityEngine;
using System.Collections;


public class Tilt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 10.0f;
    public int maxTilt = 10; 

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Horizontal") * speed;
        float rotation = Input.GetAxis("Vertical") * speed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Rotate(0, 0, -translation);

        // Rotate around our y-axis
        transform.Rotate(rotation, 0, 0);

        if(translation>maxTilt) {
            translation = maxTilt;
        }
        
    }
}
