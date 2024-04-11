using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : GameCompanent {
    [SerializeField] float _minHeadAngle = -90f;
    [SerializeField] float _maxHeadAngle = 90f;
    [SerializeField] private Transform _cameraPoint;
    [SerializeField] Transform _head;

    [SerializeField] private float _moveSpeed;

    private PlayerController _controller;
    private Rigidbody _rigidbody;

    private float _inputH;
    private float _inputV;
    private float _rotateX;
    private float _rotateY;
    private float _currentRotateX;

    public Transform Transform => transform;

    public void Init(PlayerController controller) {
        _controller = controller;
        _controller.InputDataChanged += SetInput;

        SetCameraInPositon();

        _rigidbody ??= GetComponent<Rigidbody>();
    }

    private void OnDisable() {
        _controller.InputDataChanged -= SetInput;
    }

    private void Update() {
        RotateX(_rotateX);
    }

    private void FixedUpdate() {
        Move();
        RotateY();
    }

    private void SetCameraInPositon() {
        Transform camera = Camera.main.transform;
        camera.parent = _cameraPoint;
        camera.localPosition = Vector3.zero;
        camera.localRotation = Quaternion.identity;
    }

    private void SetInput(InputData inputData) {
        _inputH = inputData.HorizontalAxisValue;
        _inputV = inputData.VerticalAxisValue;
        _rotateX = inputData.RotateX;
        _rotateY += inputData.RotateY;
    }

    private void Move() {
        Vector3 velocity = (transform.forward * _inputV + transform.right * _inputH).normalized * _moveSpeed;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

    private void RotateX(float value) {
        _currentRotateX = Mathf.Clamp(_currentRotateX + value, _minHeadAngle, _maxHeadAngle);
        _head.localEulerAngles = new Vector3(_currentRotateX, 0, 0);
    }

    private void RotateY() {
        _rigidbody.angularVelocity = new Vector3(0f, _rotateY, 0f);
        _rotateY = 0;
    }
}