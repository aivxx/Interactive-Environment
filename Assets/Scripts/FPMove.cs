using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPMove : MonoBehaviour
{
    // Player's movement parameters
    public Vector3 direction; // The player's direction at any given time
    public float speed; // The player's speed at any given time

    public Rigidbody rb; // The player's rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // All physics calculations happen in FixedUpdate
    void FixedUpdate()
    {
        // transform.Translate(direction * speed * Time.deltaTime);
        // make world direction into local direction
        Vector3 localDirection = transform.TransformDirection(direction);
        // move using physics
        rb.MovePosition(rb.position + (localDirection * speed * Time.deltaTime));
    }

    // OnPlayerMove event handler
    public void OnPlayerMove(InputValue value)
    {

        // A vector with x and y components corresponding to the player's WASD and Arrow inputs
        // both components are in the range [-1, 1]
        Vector2 inputVector = value.Get<Vector2>();

        // move in the XZ-plane
        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }
}
