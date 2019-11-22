using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateShip : MonoBehaviour
{
    public Transform xMarksTheSpot; // reference to Xmarks the spot transform.
    public TreasureChest treasureChest; // reference to TreasureChest script. 
    public float moveSpeed; // speed at which we move around the map.

    private XMarksTheSpot m_xMarksTheSpot;


    // Start is called before the first frame update
    void Start()
    {
        // searches the transform of XMarksTheSpot and looks for the script component.
        m_xMarksTheSpot = xMarksTheSpot.GetComponent<XMarksTheSpot>();
    }

    // Update is called once per frame
    void Update()
    {
        // If our current position is greater than .5 distance away, keep moving towards it. 
        if(Vector3.Distance(transform.position, xMarksTheSpot.position) >= 0.1f)
        {
            //updating our position to slowly move towards out XMarks position. s
            transform.position = Vector3.MoveTowards(transform.position, xMarksTheSpot.position, Time.deltaTime * moveSpeed);
        }
        else if(Vector3.Distance(transform.position, xMarksTheSpot.position) <= 0.1f)
        {
            // we are on top of the treasure.
            treasureChest.SearchForTreasure();
            // we want a new position for our X
            // Assigning new random position by creating a new instance of the Vector3 class and giving it some default values...
            m_xMarksTheSpot.MoveToNewPosition();
        }
    }
}
