using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameCompanentsConfig), menuName = "Configs/" + nameof(GameCompanentsConfig))]
public class ShowpieceConfigs : ScriptableObject {
    [field: SerializeField] public List<ShowpieceConfig> Configs { get; private set; }
}
