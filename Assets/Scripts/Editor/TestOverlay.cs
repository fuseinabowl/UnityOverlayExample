using System.Collections;
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
    public static TestOverlay instance = null;

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

    public TestOverlay()
        : base(
            TestButton.id
        )
    {
    }
}
