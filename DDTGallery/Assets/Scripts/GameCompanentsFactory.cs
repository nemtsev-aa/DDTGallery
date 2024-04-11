using System.Linq;
using UnityEngine;
using Zenject;

public class GameCompanentsFactory {
    private DiContainer _container;
    private GameCompanentsConfig _config;
    private GameCompanent _companent;

    public GameCompanentsFactory(DiContainer container, GameCompanentsConfig config) {
        _container = container;
        _config = config;
    }

    public T Get<T>(Transform spawnPoint) where T : GameCompanent {
        _companent = _config.Prefabs.FirstOrDefault(companent => companent is T);

        if (_companent == null) {
            Debug.Log($"Can't find prefab type of: {typeof(T)} ");

            return null;
        }

        return (T)_container.InstantiatePrefabForComponent<GameCompanent>(_companent, spawnPoint);
    }
}
