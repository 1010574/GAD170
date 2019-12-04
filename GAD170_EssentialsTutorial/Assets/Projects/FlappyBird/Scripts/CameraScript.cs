using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script to handle the camera movement of our camera
/// </summary>
public class CameraScript : MonoBehaviour
{
    public Vector3 offset; // offsets the transform, when moving by x,y,z
    public Transform player;
    private Vector3 startPosition; // the starting position of the frist frame of the game.

    private void Start()
    {
        // Getting starting position in first frame and storing it.
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // moves the camera along with the player, only taking into account the players X position. We also add an offset.
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z) + offset;
    }

    /// <summary>
    /// Resets to starting position.
    /// </summary>
    public void Reset()
    {
        transform.position = startPosition;
    }
}
