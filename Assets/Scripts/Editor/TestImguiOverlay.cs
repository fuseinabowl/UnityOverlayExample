using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Overlays;

[Overlay(typeof(SceneView), "Test IMGUI Overlay")]
public class TestImguiOverlay : IMGUIOverlay
{
    private static List<TestImguiOverlay> instances = new List<TestImguiOverlay>();

    public override void OnCreated()
    {
        instances.Add(this);
    }

    public override void OnWillBeDestroyed()
    {
        instances.Remove(this);
    }

    public static void DoWithInstances(Action<TestImguiOverlay> doWithInstance)
    {
        foreach (var instance in instances)
        {
            doWithInstance(instance);
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
