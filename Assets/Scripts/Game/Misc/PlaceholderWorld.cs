using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PlaceholderWorld : MonoBehaviour
{

	public TerrainGeneration.TerrainHeightSettings heightSettings;

	void Update()
	{
		if (!Application.isPlaying)
		{
			transform.position = Vector3.zero;
			transform.localScale = Vector3.one * heightSettings.worldRadius * 2;
		}
	}
}
