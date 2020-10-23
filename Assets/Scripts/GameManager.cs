using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Cube cubeSO;
    public CubePrefabScript cubeGO;

    [SerializeField]
    Transform cubesParent;
    private void Start()
    {
        CubePrefabScript tempGO;
        Vector3 tempPos;
        cubeSO.cubePostions = new Vector3[10];

        for (int i = 0; i < 10; i++)
        {
            cubeSO.cubePostions[i] = cubeSO.startingPostion + Vector3.right * i *1.7f; 
        }

        foreach(Vector3 pos in cubeSO.cubePostions)
        {
            tempGO = Instantiate(cubeGO, cubesParent);
            tempGO.transform.localScale = new Vector3(1, Random.Range(cubeSO.minHeight, cubeSO.maxHeight),1);
            tempPos = pos;
            tempPos.y += tempGO.transform.localScale.y / 2;
            tempGO.transform.localPosition = tempPos;
        }
    }
}
