using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.Toolbars;
using UnityEditor.Overlays;

[EditorToolbarElement(id, typeof(SceneView))]
class TestButton : EditorToolbarButton
{
    public const string id = "OverlayTest/TestButton";

    public TestButton()
    {
        icon = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Scripts/Editor/puzzle.png");
        tooltip = "Puzzling!";
    }
}

[Overlay(typeof(SceneView), "Test Overlay", displayName:"Test Overlay", ussName:"TestOverlay", defaultDisplay:true)]
public class TestOverlay : ToolbarOverlay
{
    private static List<TestOverlay> instances = new List<TestOverlay>();

    public override void OnCreated()
    {
        instances.Add(this);
    }

    public override void OnWillBeDestroyed()
    {
        instances.Remove(this);
    }

    public static void DoWithInstances(Action<TestOverlay> doWithInstance)
    {
        foreach (var instance in instances)
        {
            doWithInstance(instance);
        }
    }

    public TestOverlay()
        : base(
            TestButton.id
        )
    {
    }
}
