using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This column script will make the columns move up and down, or at least some of them will.
/// </summary>
public class Column : MonoBehaviour
{

    public bool isMovingColumn = false; // Determines if column is a moving one.
    public float moveSpeed = 2f; // speed column moves
    private float yMoveToPosition; // this is the position column in moving towards
    private float yMinPosition; // this is the minimum column can move down to.
    private float yMaxPosition; // this is the maximum column can move to.
    private bool isMovingUpwards; // Is the column moving up or down.
    private float startingYPosition; // the starting Y position of our column.

    public float maxUpMovePosition = 2; // the random max position to move to
    public float maxDownMovePosition = -2; // the random min position to move to.



    // Start is called before the first frame update
    void Start()
    {
                   
    }

    /// <summary>
    /// Sets up position of column
    /// </summary>
    public void SetPosition()
    {
        // Setting the min and max positions of columns
        yMaxPosition = Random.Range(0.1f, maxUpMovePosition);
        yMinPosition = Random.Range(0.1f, maxDownMovePosition);
        // Set the starting point.
        startingYPosition = transform.position.y;

        // Determines if column is static or moving.
        isMovingColumn = Random.Range(0, 2) > 0 ? true : false;

        // Set move to position to moving upwards.
        yMoveToPosition = startingYPosition + yMaxPosition;
        isMovingUpwards = true;
    }

    // Update is called once per frame
    void Update()
    {
        // if our column is a static column, just return.
        if (!isMovingColumn)
        {
            return;
        }

        float tempY = Mathf.MoveTowards(transform.position.y, yMoveToPosition, Time.deltaTime * moveSpeed); // will store new Y position to move to.

        transform.position = new Vector3(transform.position.x, tempY, transform.position.z); // Update position to new Y position.

        if (transform.position.y >= yMoveToPosition && isMovingUpwards)
        {
            // must have reached the max height. Switch to move down.
            Debug.Log("Moving to bottom");
            yMinPosition = Random.Range(0.1f, maxDownMovePosition); // change min/max each time we reach top and bottom.

            yMoveToPosition = startingYPosition + yMinPosition; // sets position of min move to.
            isMovingUpwards = false; // we are now moving down...

        }
        else if(transform.position.y <= yMoveToPosition && isMovingUpwards == false)
        {
            // must have reached the bottom... Switch to move up.
            Debug.Log("Moving to top");
            isMovingUpwards = true;
            yMaxPosition = Random.Range(0.1f, maxUpMovePosition); // change the max value.

            yMoveToPosition = startingYPosition + yMaxPosition; // sets value to move up to.
            
        }
    }
}
