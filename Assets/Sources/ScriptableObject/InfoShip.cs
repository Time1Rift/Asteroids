using UnityEngine;

[CreateAssetMenu(fileName = "New InfoShip", menuName = "Info/Create new InfoShip", order = 51)]
public class InfoShip : ScriptableObject
{
    [field: SerializeField, Min(0f)] public float UnitsPerSecond { get; private set; } = 0.001f;
    [field: SerializeField, Min(0f)] public float MaxSpeed { get; private set; } = 0.0015f;
    [field: SerializeField, Min(0f)] public float SecondsToStop { get; private set; } = 1f;
    [field: SerializeField, Min(0f)] public float DegreesPerSecond { get; private set; } = 180;
    [field: SerializeField, Min(0f)] public float Rotation { get; private set; } = 180;
    [field: SerializeField] public Vector2 Position { get; private set; } = new Vector2(0.5f, 0.5f);
}