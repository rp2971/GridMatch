using System.Collections.Generic; using UnityEngine;  public class GridManager : MonoBehaviour {     //public const int COLS = 6;     //public const int ROWS = 3;     //int[,] _gems = new int[COLS, ROWS];      //void Start()     //{      //    _gems[0, 0] = Random.Range(0, 9);     //    _gems[0, 1] = Random.Range(0, 9);     //    _gems[0, 2] = Random.Range(0, 9);     //    _gems[1, 0] = Random.Range(0, 9);     //    // _gems[2,1] = 5;      //    for (int x = 0; x < COLS; x++)     //    {     //        for (int y = 0; y < ROWS; y++)     //        {     //            int color = Random.Range(0, 9);     //            _gems[x, y] = color;     //        } // internal loop will go until it is finished      //    }       //   for(int x = 0; x < COLS; x++)     //   {     //        for (int y = 0; y < ROWS; y++)     //        {     //            Debug.Log("Gem" + x + "," + y + ":" + _gems[x,y]); // using the plus sign to stick the strings together - to log the message     //        }     //   }       //}      //void Update()     //{      //}      //int CheckColumn(GameObject currentCell, int col, int row)
    //{
    //    int matches = 1;
    //    List<GameObject> matches = new List<GameObject>();     //    for (int tempRow = row + 1; tempRow < HEIGHT; ++row)//going to start the row after
    //    {     //        GameObject tempCell = tokens[col, tempRow];     //        if (tempCell.color == currentCell.color)
    //        {
    //            matches.Add(tempCell);
    //        }     //        else
    //        {
    //            break;
    //        }      //        if (matches.Count > 3)
    //        {
    //            //do matching stuff 
    //        }     //    }
    //}      //public void CheckForMatches()
    //{
    //    GameObject currentCell;     //    for(int col = 0; col < WIDTH; ++col)
    //    {
    //        for (int row = 0; col < HEIGHT; ++row )
    //        {
    //                currentCell = tokens[col, row];     //                tempList = CheckColumn(currentCell, col, row);      //                foreach (GameObject go in tempList)
    //                {
    //                    gemsToDestroy(); // not sure if this is right 
    //                }     //        }
    //    }
    //}      //public void MakeGemsFall()
    //{
    //    for (int col = HEIGHT-1; col >=0; col--)
    //    {
    //        for(int row = WIDTH -1; row >= 0; row--)
    //        {
    //            GameObject currentToken = tokens[col, row];     //            int distance = 1;     //            GameObject destination = tokens[col, row + distance];     //            if(tokens[col, row+1] == null)
    //            {
    //                //it needs to fall
    //            }
    //        }
    //    }
    //} }   
