using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform _targetTransform;
    [SerializeField] CameraSheker _camaraShaker;

    private Vector3 _cameraOffset;
    private float _speed = 2;

    private void Awake()
    {
        _cameraOffset = transform.position + new Vector3(0,-3f,-0.3f)*2;
    }
 
    private void Update()
    {      
        MoveCamera();
    }
   
    private void MoveCamera()
    {
        transform.position = Vector3.Lerp(transform.position, _targetTransform.position +_cameraOffset, _speed * Time.deltaTime);   
    }
}
