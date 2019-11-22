using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMarksTheSpot : MonoBehaviour
{
    public TreasureChest treasureChest; // reference to treasure chest.

    /// <summary>
    /// Sets new position for the XMarks Spot. .
    /// </summary>
   public void MoveToNewPosition()
    {
        transform.position = new Vector3(treasureChest.GoldFound(-30, 30), transform.position.y, treasureChest.GoldFound(-30, 30));
    }
}
