using UnityEngine;
using System;
using System.Linq;

[CreateAssetMenu(fileName = "TileSettings", menuName = "2048/Tile Settings")]
public class TileSettings : ScriptableObject
{
    [SerializeField] private TileColor[] colors;
    public TileColor[] Colors => colors;

    [Serializable]
    public struct TileColor
    {
        public int value;
        public Color color;
    }
}