using UnityEngine;
using Zenject;

public class PlayerSpawner : MonoBehaviour {
    [SerializeField] private Transform _playerStartPoint;
    private GameCompanentsFactory _factory;

    private PlayerController _playerController;
    private Player _player;

    public Player Player => _player;

    [Inject]
    public void Construct(GameCompanentsFactory factory, PlayerController playerController) {
        _factory = factory;
        _playerController = playerController;
    }

    public void SpawnPlayer() {
        _player = _factory.Get<Player>(_playerStartPoint);
        _player.Init(_playerController);
    }
}
