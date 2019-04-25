using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int coordX;
    public int coordY;

    public Vector3 tilePosition = new Vector3(999, 999, 999);


    void Start()
    {
        
    }

    void Update()
    {
        if(tilePosition != new Vector3(999, 999, 999))
        {
            //Debug.Log("!");
            transform.position = Vector3.Lerp(transform.position, tilePosition, 0.5f); //move tile towards next tile

            if(transform.position == tilePosition)
            {
                tilePosition = new Vector3(999, 999, 999);
            }
        }
    }

    public void ReceiveTilePosition(Vector3 position)
    {
        tilePosition = position;
    }

    public void StoreTileCoords(int x, int y)
    {
        coordX = x;
        coordY = y; 
    }
}
