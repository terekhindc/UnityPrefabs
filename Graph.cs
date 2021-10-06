using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public Vector2[] coordinates;
    public float pointSize = 0.3f;
    
    private void Start()
    {
        foreach (Vector2 coordinate in coordinates)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position = coordinate;
            go.transform.localScale = Vector3.one * pointSize;
        }
    }
}
