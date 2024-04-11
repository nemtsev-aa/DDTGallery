using UnityEngine;
using Zenject;

public class GlobalInstallers : MonoInstaller {
    [SerializeField] private Player _playerPrefab;

    [SerializeField] private ShowpieceConfigs _showpieceConfigs;
    [SerializeField] private ShowpieceSpawnPointConfig _showpieceSpawnPointConfig;

    [SerializeField] private GameCompanentsConfig _gameCompanentsConfig;

    public override void InstallBindings() {
        BindServices();
        BindFactories();
    }

    private void BindServices() {
        Container.Bind<PlayerController>().AsSingle();
    } 

    private void BindFactories() {
        Container.Bind<ShowpieceConfigs>().FromInstance(_showpieceConfigs).AsSingle();
        Container.Bind<ShowpieceSpawnPointConfig>().FromInstance(_showpieceSpawnPointConfig).AsSingle();
        Container.Bind<GameCompanentsConfig>().FromInstance(_gameCompanentsConfig).AsSingle();
        Container.Bind<GameCompanentsFactory>().AsSingle();
    }
}
