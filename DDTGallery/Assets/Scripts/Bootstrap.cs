using UnityEngine;

public class Bootstrap : MonoBehaviour {
    [SerializeField] private PlayerSpawner _playerSpawner;

    private void Start() {



        _playerSpawner.SpawnPlayer();

    }
}
