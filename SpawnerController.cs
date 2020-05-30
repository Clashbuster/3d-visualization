using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

hallo hallo
more more more


yo yo yo yo

wowowowowowowowowowowo


  public class Cell
    {
        GameObject square = null;
        int wall = 0;
        int visited = 0;
        int queued = 0;

        public Cell(GameObject cuberef)
        {
            this.square = cuberef;
                int wall = 0;
                int visited = 0;
                int queued = 0;
        }
    }






    public GameObject cubePrefab = null;
    public GameObject wallPrefab = null;
    // Start is called before the first frame update
    public int width;
    public int height;
    Cell[,] grid;
    int interval;
    int gap;

    public void Awake()
            {
             interval =    Random.Range(3,7);
            }


    public void createGrid()
    {
        Debug.Log(interval);
        grid = new Cell[this.width, this.height];
          for(int x = 0; x < width; x++)
            {
                bool wall;
                gap = Random.Range(0,height - 1);
                if(x > 1 && x < width - 2)
                {
                   if(x % interval == 0)
                        {
                            wall = true;
                        }
                        else{
                            wall = false;
                        } 
                }
                else
                {
                    wall = false;
                }
                        Debug.Log(wall);
                
                for(int y = 0; y < height; y++)
                {
                    this.transform.position = new Vector3 (x, transform.position.y, y);
                    GameObject cubeRef;


                     if(wall == true)
                     {
                         if(y == gap)
                         {
                            cubeRef = spawnCube(cubePrefab); 
                         }
                         else
                         {
                              cubeRef = spawnCube(wallPrefab);
                         }
                     }
                     else
                     {
                          if(y % interval == 0)
                        {
                            if(x % interval == Random.Range(2,interval)){
                               cubeRef = spawnCube(cubePrefab);
                            }
                            else{
                                cubeRef = spawnCube(wallPrefab);
                            }
                        }
                        else{
                            cubeRef = spawnCube(cubePrefab);
                        } 
                     }
                    grid[x,y] = new Cell(cubeRef);
                }
            }
    }


    void Start()
    {
      createGrid();
    }



        GameObject spawnCube(GameObject cubeRef)
            {
                GameObject cubeInstance = Instantiate(
                    cubeRef,
                    transform.position,
                    transform.rotation
                );
                return cubeInstance;
            }








    // Update is called once per frame
    void Update()
    {
        
    }
}