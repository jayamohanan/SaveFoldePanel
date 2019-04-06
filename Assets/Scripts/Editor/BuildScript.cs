using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

public class BuildScript{
    [MenuItem("Jaya/BuildAndroid")]
	static void PerformBuild()
    {
        //Debug.Log("In PerformBuild function")
        //PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.Mohanan.Jayam");
        //BuildReport report = 
        string[] defaultScene = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./Builds/From_Editor",
            BuildTarget.Android, BuildOptions.None);
       // BuildSummary summary = report.summary;
    }
}   
