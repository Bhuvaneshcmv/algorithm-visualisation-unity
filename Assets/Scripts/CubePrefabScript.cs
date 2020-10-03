using UnityEngine;

public class CubePrefabScript : MonoBehaviour
{
    public float height;
    public MeshRenderer CubeMeshRenderer;
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

}
