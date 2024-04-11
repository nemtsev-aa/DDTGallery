using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = nameof(ShowpieceSpawnPointConfig), menuName = "Configs/" + nameof(ShowpieceSpawnPointConfig))]
public class ShowpieceSpawnPointConfig : ScriptableObject {
    [field: SerializeField] public List<Transform> Points { get; private set; }
}
