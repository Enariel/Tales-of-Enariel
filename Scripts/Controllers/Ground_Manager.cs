
using System;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Manager : MonoBehaviour
{
	public List<Texture2D> groundLevels = new List<Texture2D>();
	public List<GameObject> groundPrefab = new List<GameObject>();
	public List<Color> colourArray;
	public Color targetColor;

	public int imgWidth;
	public int imgHeight;

	private Transform centerPoint;
	private List<Vector3> targetTerrain = new List<Vector3>();
	public void Start()
	{
		centerPoint = GameObject.FindGameObjectWithTag("CenterPoint").transform;

		foreach (Texture2D levelMap in groundLevels)
		{
			imgHeight = levelMap.height;
			imgWidth = levelMap.width;

			for (int y = 0; y < imgHeight; y++)
			{
				for (int x = 0; x < imgWidth; x++)
				{
					colourArray.Add(levelMap.GetPixel(x, y));
					targetTerrain.Add(new Vector3(x, 0f, y));
				}
			}

			int i = 0;
			while (i < colourArray.Count)
			{
				if (colourArray[i] == targetColor)
				{
					var terrainObj = Instantiate(groundPrefab[0], groundPrefab[0].transform.position + targetTerrain[i], Quaternion.identity);
				}
				i++;
			}
		}
	}
}
