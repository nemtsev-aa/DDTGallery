using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ShowpieceSpawner : MonoBehaviour {
    private GameCompanentsFactory _factory;
    private ShowpieceConfigs _showpieceConfigs;
    private ShowpieceSpawnPointConfig _showpieceSpawnPointConfig;

    private List<Showpiece> _showpieces;

    [Inject]
    public void Construct(GameCompanentsFactory factory,
                          ShowpieceConfigs showpieceConfigs,
                          ShowpieceSpawnPointConfig showpieceSpawnPointConfig) {

        _factory = factory;
        _showpieceConfigs = showpieceConfigs;
        _showpieceSpawnPointConfig = showpieceSpawnPointConfig;
    }

    public void SpawnShowpiece() {
        _showpieces = new List<Showpiece>();

        foreach (var iPrefab in _showpieceConfigs.Configs) {

        }

        //_player = _factory.Get<Player>(_playerStartPoint);
        //_player.Init(_playerController);
    }
}
