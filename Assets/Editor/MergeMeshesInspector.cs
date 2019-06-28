using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
[CustomEditor(typeof(MergeMeshes))]
public class MergeMeshesInspector : Editor {
	bool toggleUseOtherGameobject = false;
	bool toggleHideMeshes = false;
	bool toggleManualMerge = false;
	GameObject backup;
	MergeMeshes mergeMeshes;
	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();
		mergeMeshes = (MergeMeshes)target;
		toggleUseOtherGameobject = GUILayout.Toggle (toggleUseOtherGameobject, "Use other gameobject as parent?");
		toggleManualMerge = GUILayout.Toggle (toggleManualMerge, "Manualy merge together");

		if (toggleUseOtherGameobject) {
			mergeMeshes.GeneratedMeshesParent = backup != null ? backup : null;
			mergeMeshes.GeneratedMeshesParent = (GameObject)EditorGUILayout.ObjectField (mergeMeshes.GeneratedMeshesParent, typeof(GameObject), true);
			backup = mergeMeshes.GeneratedMeshesParent;
		}
		else
			mergeMeshes.GeneratedMeshesParent = mergeMeshes.gameObject;
		if (GUILayout.Button("Merge Meshes")) {
			mergeMeshes.Merge (() => {GameObject test = GameObject.Find (mergeMeshes.genName);
				if(Application.isEditor)
				{
					if (test != null)
					{
						Debug.Log("Updated " + test.name + " meshes");
						Object.DestroyImmediate (test);
					}
				}}, (x) => {
				if(mergeMeshes.GenerateUV2 && !Application.isPlaying)
					Unwrapping.GenerateSecondaryUVSet (x);
			});
		}
		if(GUILayout.Button((toggleHideMeshes ? "Unhide " : "Hide ") + "old geometry"))
		{
			mergeMeshes.HideToggle (toggleHideMeshes);
			toggleHideMeshes = !toggleHideMeshes;
		}
		if (toggleManualMerge) {
			mergeMeshes.objToMerge_01 = (GameObject)EditorGUILayout.ObjectField (mergeMeshes.objToMerge_01, typeof(GameObject), true);
			mergeMeshes.objToMerge_02 = (GameObject)EditorGUILayout.ObjectField (mergeMeshes.objToMerge_02, typeof(GameObject), true);
			if(GUILayout.Button(("Manual merge")))
			{
				mergeMeshes.Merge (mergeMeshes.objToMerge_01 , mergeMeshes.objToMerge_02);
			}
		}
		if (GUI.changed && Application.isEditor && !Application.isPlaying) {
			EditorUtility.SetDirty (mergeMeshes);
			EditorSceneManager.MarkSceneDirty (SceneManager.GetActiveScene ());
		}
	}
}
