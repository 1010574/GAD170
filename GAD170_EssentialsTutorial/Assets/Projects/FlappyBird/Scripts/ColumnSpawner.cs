using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A spawner to spawn in all our columns and manage them
/// </summary>
public class ColumnSpawner : MonoBehaviour
{

    public GameObject columnPrefab; // the object we want to spawn in.
    public int columnPoolSize = 5; // Max number of columns that can spawn in at once.
    public float spawnRate = 3; // The time between spawning columns
    public float columnYMin = -1; // Minimum Y value of the column
    public float columnYMax = 3.5f; // Max Y value of column.

    private List<GameObject> columns = new List<GameObject>(); // List that holds all columns that are spawned in.
    private float m_spawnXposition = 15f; // Position we will spawn column.
    private int m_currentColumn = 0; // the current column we are up to in our spawn list.
    private Vector3 objectPoolPosition = new Vector3(-1000, -1000, -1000); // somewhere off screen.

    public Transform environment; // a reference to the environment object.
    public Transform player; // reference to player object.


    // Start is called before the first frame update
    void Start()
    {
        // Start spawning columns.
        Initialise(); 
    }

    /// <summary>
    /// Will initialise spawning system
    /// </summary>
    private void Initialise()
    {
        m_spawnXposition = 10;
        // Reset our current column position
        m_currentColumn = 0;
        // Clear and destroy any current columns.
        if (columns.Count > 0)
        {
            // iterate through each column and destroy it.
            for(int i=0; i<columns.Count; i++)
            {
                Destroy(columns[i]);
            }
            // Clear our list to be 0 elements long
            columns.Clear();
        }

        // Loop through pool size and spawn in a column
        for(int j=0; j<columnPoolSize; j++)
        {
            // Spawns in an object using the object I want to spawn, the position it should spawn, and the rotation it should have.
            GameObject spawnedInColumn = Instantiate(columnPrefab, objectPoolPosition, columnPrefab.transform.rotation);
           
            // Adds the column to the spawned in list.
            columns.Add(spawnedInColumn);
        }

        // Calls the SpawnColumns function immediately and repeatedly calls the function after 3 seconds, until we tell it to stop.
        InvokeRepeating("SpawnColumns", 0, spawnRate);

    }

    /// <summary>
    /// This handles spawning our columns
    /// </summary>
    private void SpawnColumns()
    {
       
        // set a random Y position for column.
        float spawnYposition = Random.Range(columnYMin, columnYMax);

        // set the current column up to in list. Get it and change it's position.
        columns[m_currentColumn].transform.position = new Vector3(15 + player.transform.position.x, spawnYposition, 0);

        // then reset the position of the column.
        columns[m_currentColumn].GetComponent<Column>().SetPosition();

        // interate to our next column
        m_currentColumn++;

        // If we iterate past our pool size, reset the current column to 0.
        if(m_currentColumn >= columnPoolSize)
        {
            m_currentColumn = 0;
        }

    }

    /// <summary>
    /// Resets our spawning system.
    /// </summary>
    public void Reset()
    {
        // Cancels the spawner
        CancelInvoke("SpawnedColumns");
       
        // Resets the world to start spawning again.
        Initialise();
    }
}
