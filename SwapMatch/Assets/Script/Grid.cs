using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    private GameObject[,] tiles;
    public GameObject[] Player; 

    //private GameObject[] tileArray = new GameObject[4];

    public Vector3 Origin;
    public int width;
    public int height; 

    public GameObject tileinstance; // giving a reference to what we are instantiating (the gameobject) 
    public GameObject Playerinstance;

    public List<Color> colorList = new List<Color>();

    //public Color red = Color.red;
    //public Color black = Color.black;
    //public Color blue = Color.blue;
    //public Color yellow = Color.yellow;
    //public Color magenta = Color.magenta;
    //public Color cyan = Color.cyan;

    private void Awake() // awake to instantiate numbers
    {
        tiles = new GameObject[width, height]; //2D array
    }

    private void Start()  
    {
        //GameObject Player = Instantiate(Playerinstance, new Vector3(0, 0, 0), Quaternion.identity); // creating a new tile + filling it
        //GameObject tile2 = Instantiate(tileinstance, new Vector3(1, 0, 0), Quaternion.identity); 

        int counterX = 0;
        //int counterY = 0;

        for (int j = 0; j < height; j++) // j = cols
        {
        
            for (int i = 0; i < width; i++) // i = rows
            {
                tiles[i,j] = Instantiate(tileinstance, Origin + new Vector3(i,j,0), Quaternion.identity);
                counterX++;
                tiles[i, j].GetComponent<SpriteRenderer>().color = colorList[Random.Range(0, 6)];

            }

            //counterX = 0;
            //counterY++;

        }

        //tiles[0, 0].GetComponent<SpriteRenderer>().color = colorList[Random.Range(0, 5)];
        //tiles[1, 0].GetComponent<SpriteRenderer>().color = colorList[Random.Range(0, 6)];
        //tiles[2, 0].GetComponent<SpriteRenderer>().color = colorList[Random.Range(0, 6)];
        //tiles[3, 0].GetComponent<SpriteRenderer>().color = colorList[Random.Range(0, 6)];
    }
}
