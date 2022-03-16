using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DummyBehaviour))]
public class DummyBehaviourEditor : Editor
{
    public void OnEnable()
    {
        TestOverlay.DoWithInstances(instance => instance.displayed = true);
    }

    public void OnDisable()
    {
        TestOverlay.DoWithInstances(instance => instance.displayed = false);
    }
}
