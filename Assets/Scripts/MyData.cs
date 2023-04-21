using System;
using System.Runtime.InteropServices;
using UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack =1)]
public struct MyData
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public Vector3 position;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string name;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public int health;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public int shield;


    public override string ToString()
    {
        return $"{name}, health:{health}, shield:{shield} @ {position}";
    }
}
