using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMesh : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        Mesh m = new Mesh();

        m.vertices = new Vector3[]
        {
            new Vector3(-3.0f, -3.0f, 0.0f),
            new Vector3(-3.0f, 3.0f, 0.0f),
            new Vector3(3.0f, 3.0f, 0.0f),
            new Vector3(3.0f, -3.0f, 0.0f)
        };

        m.triangles = new int[] { 0, 1, 2, 0, 2, 3 };
        m.uv = new Vector2[]
        {
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 1.0f),
            new Vector2(1.0f, 1.0f),
            new Vector2(1.0f, 0.0f)
        };

        m.colors = new Color[]
        {
            new Color(0.2f, 0.45f, 1.0f),
            new Color(1.0f, 0.925f, 0.25f),
            new Color(0.1f, 1f, 0.45f),
            new Color(0.95f, 0.55f, 0.8f)
        };

        GetComponent<MeshFilter>().mesh = m;
    }
}
