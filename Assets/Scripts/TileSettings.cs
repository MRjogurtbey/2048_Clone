using UnityEngine;
using System;

[CreateAssetMenu(fileName = "TileSettings", menuName = "2048/Tile Settings")]
public class TileSettings : ScriptableObject
{
    public TileColor[] colors;

    [Serializable]
    public struct TileColor
    {
        public int value;
        public Color color;
    }
}