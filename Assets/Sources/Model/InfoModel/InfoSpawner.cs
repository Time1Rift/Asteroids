using UnityEngine;

[CreateAssetMenu(fileName = "New InfoSpawner", menuName = "Info/Create new InfoSpawner", order = 51)]
public class InfoSpawner : ScriptableObject
{
    [field: SerializeField, Min(0f)] public float TimeSpawn { get; private set; } = 2f;
    [field: SerializeField, Min(0)] public int MaxPercentage { get; private set; } = 100;
    [field: SerializeField, Min(0)] public int ChanceNlo { get; private set; } = 20;
    [field: SerializeField, Min(0f)] public float SpeedNlo { get; private set; } = 0.075f;
    [field: SerializeField, Min(0f)] public float SpeedAsteroid { get; private set; } = 0.075f;
    [field: SerializeField] public Vector2 RandomPositionFactor { get; private set; } = new Vector2(0.5F, 0.5F);
}