using UnityEngine;

[CreateAssetMenu(fileName = "Cube Properties", menuName = "ScriptableObjects / Cubes")]
public class Cube : ScriptableObject
{
    public int numberOfCubes;
    public Vector3 startingPostion;
    
    public Vector3[] cubePostions;
    public float[] cubeHeights;
}
