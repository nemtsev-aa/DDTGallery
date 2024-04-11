using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameCompanentsConfig), menuName = "Configs/" + nameof(GameCompanentsConfig))]
public class GameCompanentsConfig : ScriptableObject {
    [field: SerializeField] public List<GameCompanent> Prefabs { get; private set; }
}
