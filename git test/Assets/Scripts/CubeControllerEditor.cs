using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CubeController))]
public class CubeControllerEditor : Editor
{
    private void OnSceneGUI()
    {
        var cc = target as CubeController;
        var movementSpeed = serializedObject.FindProperty("movementSpeed").floatValue;

        Handles.color = Color.white;
        Handles.DrawLine(cc.transform.position, cc.transform.position + cc.transform.forward * movementSpeed);
    }
}
