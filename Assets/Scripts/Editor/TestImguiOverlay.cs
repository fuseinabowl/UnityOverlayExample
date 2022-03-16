using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.Overlays;

[Overlay(typeof(SceneView), "Test IMGUI Overlay", displayName:"Test IMGUI Overlay", ussName:"TestImguiOverlay", defaultDisplay:true)]
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
