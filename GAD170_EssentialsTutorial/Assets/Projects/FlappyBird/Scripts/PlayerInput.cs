using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public KeyCode jumpKey = KeyCode.Space; // Keycode that makes the bird flap
    private Rigidbody myRigidBody; // reference to rigidbody component.
    public float jumpForce = 375; // force applied when space bar is pressed.
    public float fallingMass = 100; // The mass applied when falling
    public float jumpingMass = 1; // the mass applied when jumping
    public float moveSpeed = 5; // The speed we move across the screen.

    private GameManager gameManager; // reference to game manager
    private Vector3 startingPosition; // reference to starting position.
    private AudioManager audioManager; // reference to AudioManager.

    // Start is called before the first frame update
    void Start()
    {
        // checks to see if object has a rigidbody attached..
        if (GetComponent<Rigidbody>())
        {
            // if so, sets myRigidBody to the objects rigidbody.
            myRigidBody = GetComponent<Rigidbody>();
        }
        else
        {
            Debug.Log("No rigidbody on object");
        }

        gameManager = FindObjectOfType<GameManager>();
        startingPosition = transform.position;
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
        
    }

    /// <summary>
    /// Handles jumping mechanic of our flappybird.
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            myRigidBody.mass = jumpingMass;
            // adds a force to our rigid body on the Y axis, multiplied by jump force.
            myRigidBody.AddForce(Vector3.up * jumpForce * jumpingMass);
        }
        // this sets the rigid body to a higher mass, so we fall faster after jumping.
        if(myRigidBody.mass != fallingMass)
        {
            myRigidBody.mass = fallingMass;
        }
    }

    /// <summary>
    /// Handles the horizontal movement of our flappybird. 
    /// </summary>
    private void Move()
    {
        // differnt ways to do movement.
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed;
        // Lerp moves fast towards goal position, and then slows down as it gets closer.
       // transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right, Time.deltaTime);
        // move towards moves at a constant rate towards a position.
       // transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.right, Time.deltaTime);
    }

    public void Reset()
    {
        // resets the players position to the starting point.
        transform.position = startingPosition;
    }

    /// <summary>
    /// Detects when the player collides with something. The player needs to have a rigidbody and a collider for this to work. 
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // call our reset function.
        Debug.Log("We Dead fam");
        gameManager.ResetGame();
        audioManager.Dead();
    }

}
