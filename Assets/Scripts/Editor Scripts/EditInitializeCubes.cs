using UnityEditor;
using UnityEngine;

public class InitializeCubes : EditorWindow
{
    public Cube cubeProps;
    
    [MenuItem("Window/Edit Mode Functions")]
    public static void ShowWindow()
    {
        GetWindow<InitializeCubes>("Edit Mode Functions");
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Initialize Positions"))
        {
            LoadInitialPositions();
        }
        if (GUILayout.Button("Load Random heights"))
        {
            LoadRandomHeight();
        }
    }

    public void LoadInitialPositions()
    {
        
    }
    
    public void LoadRandomHeight()
    {
        
    }
}
