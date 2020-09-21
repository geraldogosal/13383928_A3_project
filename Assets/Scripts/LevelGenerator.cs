using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    private float tileSize = 1;
    protected int[,] mapRotation = {
        {0,1,1,1,1,1,1,1,1,1,1,1,1,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,1,1,3,0,0,1,1,1,3,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,1,1,1,2,0,1,1,1,1,2,0,1},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,1,1,3,0,0,3,0,0,1,1,1},
        {0,0,1,1,1,2,0,0,0,0,1,1,1,3},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {1,1,1,1,1,3,0,0,1,1,1,3,0,0},
        {0,0,0,0,0,0,0,0,0,1,1,2,0,1},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,1,1,0},
        {1,1,1,1,1,2,0,1,2,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        };

    // Start is called before the first frame update
    void Start()
    {

        GenerateGrid(0, 0, 1, 1, "lefttop");
        GenerateGrid(-27, 0, -1, 1, "righttop");
        GenerateGrid(-27, -28, -1, -1, "rightbottom");
        GenerateGrid(0, -28, 1, -1, "leftbottom");
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void GenerateGrid(int a, int b, int c, int d, string position)
    {
        /*int[] row1 = { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 7 };
        int[] row2 = { 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4 };
        int[] row3 = { 2, 5, 3, 4, 4, 3, 5, 3, 4, 4, 4, 3, 5, 4 };
        int[] row4 = { 2, 6, 4, 0, 0, 4, 5, 4, 0, 0, 0, 4, 5, 4 };
        int[] row5 = { 2, 5, 3, 4, 4, 3, 5, 3, 4, 4, 4, 3, 5, 3 };
        int[] row6 = { 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        int[] row7 = { 2, 5, 3, 4, 4, 3, 5, 3, 3, 5, 3, 4, 4, 4 };
        int[] row8 = { 2, 5, 3, 4, 4, 3, 5, 4, 4, 5, 3, 4, 4, 3 };
        int[] row9 = { 2, 5, 5, 5, 5, 5, 5, 4, 4, 5, 5, 5, 5, 4 };
        int[] row10 = { 1, 2, 2, 2, 2, 1, 5, 4, 3, 4, 4, 3, 0, 4 };
        int[] row11 = { 0, 0, 0, 0, 0, 2, 5, 4, 3, 4, 4, 3, 0, 3 };
        int[] row12 = { 0, 0, 0, 0, 0, 2, 5, 4, 4, 0, 0, 0, 0, 0 };
        int[] row13 = { 0, 0, 0, 0, 0, 2, 5, 4, 4, 0, 3, 4, 4, 0 };
        int[] row14 = { 2, 2, 2, 2, 2, 1, 5, 3, 3, 0, 4, 0, 0, 0 };
        int[] row15 = { 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 4, 0, 0, 0 };
        int [][] levelMap =
        {row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15 };*/

        int[,] levelMap =
        {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };





        GameObject Map;
        float posX;
        float posY;



        for (int row = 0; row < levelMap.GetLength(0); row++)
        {

            for (int col = 0; col < levelMap.GetLength(1); col++)
            {

                if (levelMap[row, col] == 1)
                {
                    Map = GameObject.Instantiate(Resources.Load("outsidecorner")) as GameObject;
                    posX = (a + col) * tileSize * c;
                    posY = (b + row) * -tileSize * d;
                    Map.transform.position = new Vector2(posX, posY);
                    Rotate(row, col, Map, position);
                }
                else if (levelMap[row, col] == 2)
                {
                    Map = GameObject.Instantiate(Resources.Load("outsidewall")) as GameObject;
                    posX = (a + col) * tileSize * c;
                    posY = (b + row) * -tileSize * d;

                    Map.transform.position = new Vector2(posX, posY);
                    Rotate(row, col, Map, position);

                }
                else if (levelMap[row, col] == 3)
                {
                    Map = GameObject.Instantiate(Resources.Load("insidecorner")) as GameObject;
                    posX = (a + col) * tileSize * c;
                    posY = (b + row) * -tileSize * d;

                    Map.transform.position = new Vector2(posX, posY);
                    Rotate(row, col, Map, position);
                }
                else if (levelMap[row, col] == 4)
                {
                    Map = GameObject.Instantiate(Resources.Load("insidewall")) as GameObject;
                    posX = (a + col) * tileSize * c;
                    posY = (b + row) * -tileSize * d;

                    Map.transform.position = new Vector2(posX, posY);
                    Rotate(row, col, Map, position);
                }
                else if (levelMap[row, col] == 5)
                {
                    Map = GameObject.Instantiate(Resources.Load("standardpellet")) as GameObject;
                    posX = (a + col) * tileSize * c;
                    posY = (b + row) * -tileSize * d;

                    Map.transform.position = new Vector2(posX, posY);
                    Rotate(row, col, Map, position);
                }
                else if (levelMap[row, col] == 6)
                {
                    Map = GameObject.Instantiate(Resources.Load("powerpellet")) as GameObject;
                    posX = (a + col) * tileSize * c;
                    posY = (b + row) * -tileSize * d;

                    Map.transform.position = new Vector2(posX, posY);
                    Rotate(row, col, Map, position);
                }

                else if (levelMap[row, col] == 7)
                {
                    Map = GameObject.Instantiate(Resources.Load("tjunction")) as GameObject;
                    posX = (a + col) * tileSize * c;
                    posY = (b + row) * -tileSize * d;

                    Map.transform.position = new Vector2(posX, posY);
                    Rotate(row, col, Map, position);
                }

                else
                { }
            }
        }


    }

    public void Rotate(int row, int col, GameObject Map, string orientation)
    {

        if (orientation == "lefttop")
        {
            if (mapRotation[row, col] == 1)
            {

                Map.transform.Rotate(0, 0, 90);

            }
            else if (mapRotation[row, col] == 2)
            {


                Map.transform.Rotate(0, 0, 180);


            }
            else if (mapRotation[row, col] == 3)
            {


                Map.transform.Rotate(0, 0, 270);
            }
        }
        else if (orientation == "rightbottom")
        {
            if (mapRotation[row, col] == 1)
            {

                Map.transform.Rotate(180, 180, 90);

            }
            else if (mapRotation[row, col] == 2)
            {


                Map.transform.Rotate(180, 180, 180);


            }
            else if (mapRotation[row, col] == 3)
            {


                Map.transform.Rotate(180, 180, 270);
            }
            else if (mapRotation[row, col] == 0)
            {


                Map.transform.Rotate(180, 180, 0);
            }
        }


        else if (orientation == "righttop")
        {
            if (mapRotation[row, col] == 1)
            {

                Map.transform.Rotate(0, 180, 90);

            }
            else if (mapRotation[row, col] == 2)
            {


                Map.transform.Rotate(0, 180, 180);


            }
            else if (mapRotation[row, col] == 3)
            {


                Map.transform.Rotate(0, 180, 270);
            }
            else if (mapRotation[row, col] == 0)
            {


                Map.transform.Rotate(0, 180, 0);
            }
        }
        else if (orientation == "leftbottom")
        {
            if (mapRotation[row, col] == 1)
            {

                Map.transform.Rotate(180, 0, 90);

            }
            else if (mapRotation[row, col] == 2)
            {


                Map.transform.Rotate(180, 0, 180);


            }
            else if (mapRotation[row, col] == 3)
            {


                Map.transform.Rotate(180, 0, 270);
            }
            else if (mapRotation[row, col] == 0)
            {
                Map.transform.Rotate(180, 0, 0);
            }
        }

    }

}




