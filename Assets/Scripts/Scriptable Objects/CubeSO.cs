using UnityEngine;

[CreateAssetMenu(fileName = "Cube Properties", menuName = "ScriptableObjects / Cubes")]
public class CubeSO : ScriptableObject
{
    public int numberOfCubes;
    public Vector3 startingPostion;
    public int maxHeight;
    public int minHeight;

    [HideInInspector]
    public Vector3[] cubePostions;
    [HideInInspector]
    public float[] cubeHeights;
}
