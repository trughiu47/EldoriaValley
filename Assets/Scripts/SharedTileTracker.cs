using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SharedTileTracker", menuName = "Spawner/SharedTileTracker")]
public class SharedTileTracker : ScriptableObject
{
    public HashSet<Vector2Int> usedTiles = new HashSet<Vector2Int>();

    public void Clear()
    {
        usedTiles.Clear();
    }
}