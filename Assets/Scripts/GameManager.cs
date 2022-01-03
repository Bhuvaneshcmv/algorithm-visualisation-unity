using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CubeSO cubeSO;
    public Cube cubeGO;

    [SerializeField]
    Transform cubesParent;
    Cube[] cubeContainer;
    bool moveComplete;
    

    private void Start()
    {
        moveComplete = true;
        cubeContainer = new Cube[10];
        InitializationOfObjects();
    }

    private void Update()
    {
        BubbleSort();
    }

    void InitializationOfObjects()
    {
        Cube tempGO;
        Vector3 tempPos;
        cubeSO.cubePostions = new Vector3[10];
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            cubeSO.cubePostions[i] = cubeSO.startingPostion + Vector3.right * i * 1.7f;
        }

        foreach (Vector3 pos in cubeSO.cubePostions)
        {
            tempGO = Instantiate(cubeGO, cubesParent);
            tempGO.transform.localScale = new Vector3(1, Random.Range(cubeSO.minHeight, cubeSO.maxHeight), 1);
            tempPos = pos;
            tempPos.y += tempGO.transform.localScale.y / 2;
            tempGO.transform.localPosition = tempPos;
            cubeContainer[count] = tempGO;
            count++;
        }
    }

    void moveTheCube(Cube cube, Vector3 finalPos)
    {
        Vector3 initialPos = cube.transform.localPosition;

        int moveDirection = 0;
        if (finalPos.x - initialPos.x > 0) moveDirection = 1;
        if (finalPos.x - initialPos.x < 0) moveDirection = -1;

        cube.transform.Translate(Vector3.right * Time.deltaTime * moveDirection);

        if((moveDirection==1 && cube.transform.localPosition.x >= finalPos.x) || (moveDirection == -1 && cube.transform.localPosition.x <= finalPos.x))
        {
            finalPos.y = cube.transform.localScale.y / 2;
            cube.transform.localPosition = finalPos;
            moveComplete = true;
            return;
        }
    }


    void BubbleSort()
    {
        if (moveComplete == true)
        {
            moveComplete = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    if (cubeContainer[j].transform.localScale.y < cubeContainer[i].transform.localScale.y)
                    {   
                        moveTheCube(cubeContainer[j], cubeSO.cubePostions[i]);
                        /* tempInt = numberArray[i];
                         numberArray[i] = numberArray[j];
                         numberArray[j] = tempInt;*/
                    }
                }
            }
        }
    }
}
