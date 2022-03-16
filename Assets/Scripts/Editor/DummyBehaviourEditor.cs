using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DummyBehaviour))]
public class DummyBehaviourEditor : Editor
{
    public void OnEnable()
    {
        TestOverlay.instance.displayed = true;
    }

    public void OnDisable()
    {
        TestOverlay.instance.displayed = false;
    }
}
