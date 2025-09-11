
using System;
using UnityEngine;

[Serializable]
public class Position3(Transform tr)
{
    public float x = tr.position.x;
    public float y = tr.position.y;
    public float z = tr.position.z;
}
