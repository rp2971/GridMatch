using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Grid grid;
    public Player player; 

    void Start()
    {
        //Debug.Log(grid.GetTilePosition((int)player.transform.position.x, (int)player.transform.position.y));
        
        Tile tile = grid.GiveMeTileThenDelete(); //grabbed tile from grid 

        player.StoreTileCoords(tile.coordX, tile.coordY);

        player.transform.position = tile.transform.position; //moving the player to the tile position 

        //player.transform.position = grid.GetTilePosition((int)player.transform.position.x, (int)player.transform.position.y);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && player.coordX != grid.width - 1 )
        {
            Tile tile = grid.GetTile(player.coordX + 1, player.coordY);
            player.tilePosition = tile.transform.position;
            player.coordX++;
        }
        //if (// moving left checks) { 
        


    }

    
}
