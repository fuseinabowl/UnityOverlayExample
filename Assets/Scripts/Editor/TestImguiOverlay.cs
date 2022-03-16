using UnityEngine;
using UnityEditor;
using UnityEditor.Overlays;

[Overlay(typeof(SceneView), "Test IMGUI Overlay")]
public class TestImguiOverlay : IMGUIOverlay
{
    public static TestImguiOverlay instance = null;

    public override void OnCreated()
    {
        instance = this;
    }

    public override void OnWillBeDestroyed()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

    public override void OnGUI()
    {
        GUILayout.Label("Hello world");

        if (GUILayout.Button("Press me"))
        {
            Debug.Log("Button pressed");
        }
    }
}
