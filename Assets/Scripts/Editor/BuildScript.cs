using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

class BuildScript
{

    static void Build()
    {
        BuildPipeline.BuildPlayer(FindEnabledEditorScenes(), "C:/BUILD/MyGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
    private static string[] FindEnabledEditorScenes()
    {
        List<string> EditorScenes = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            EditorScenes.Add(scene.path);
        }
        return EditorScenes.ToArray();
    }
}