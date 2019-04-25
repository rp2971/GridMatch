using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    private GameObject[,] tiles;

    public Vector3 Origin;
    public int width;
    public int height; 

    public GameObject tileinstance; // giving a reference to what we are instantiating (the gameobject) 

    public List<Color> colorList = new List<Color>();

    private void Awake() // awake to instantiate numbers
    {
        tiles = new GameObject[width, height]; //2D array, array of gameobjects

        for (int j = 0; j < height; j++) // j = cols
        {

            for (int i = 0; i < width; i++) // i = rows
            {
                tiles[i, j] = Instantiate(tileinstance, Origin + new Vector3(i, j, 0), Quaternion.identity);
                tiles[i, j].GetComponent<SpriteRenderer>().color = colorList[Random.Range(0, 6)];
                tiles[i, j].GetComponent<Tile>().coordX = i;
                tiles[i, j].GetComponent<Tile>().coordY = j;
            }
        }
    }

    private void Start()  
    {

    }

        //GameObject tile = tiles[Random.Range(0, width), Random.Range(0, height)];
        //GameObject player = Instantiate(Playerinstance, tile.transform.position, Quaternion.identity);

        //Destroy(tile);
    

    public Vector3 GiveMeTilePosition()
    {
        return tiles[Random.Range(0, width), Random.Range(0, height)].transform.position;
    }

    public Tile GiveMeTileThenDelete()
    {
        int x = Random.Range(0, width);
        int y = Random.Range(0, height);

        Tile tile = tiles[x, y].GetComponent<Tile>();

        Destroy(tiles[x, y]);

        return tile;
    }

    public Vector3 GetTilePosition(int x, int y)
    {
        return tiles[x, y].transform.position;
    }

    public Tile GetTile (int x, int y)
    {
        return tiles[x, y].GetComponent<Tile>();
    }

}


