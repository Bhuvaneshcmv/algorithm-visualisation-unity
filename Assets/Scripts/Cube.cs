using UnityEngine;

public class Cube : MonoBehaviour
{
    public float height;
    public MeshRenderer CubeMeshRenderer;
    public bool isMoving;

    private void Awake()
    {
        LoadValues();
    }

    private void LoadValues()
    {
        height = gameObject.transform.localScale.y;
        CubeMeshRenderer = gameObject.GetComponent<MeshRenderer>();
        CubeMeshRenderer.material.color =  Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    public void Move()
    {

    }
}