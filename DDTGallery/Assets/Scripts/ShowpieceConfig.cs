using UnityEngine;
using System;

[Serializable]
public class ShowpieceConfig {
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public string Description { get; private set; }
    [field: SerializeField] public Sprite Sketch { get; private set; }
    [field: SerializeField] public Showpiece Prefab { get; private set; }
}
