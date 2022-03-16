using UnityEngine;

namespace ErbiumCamera
{
    public class CameraManager : MonoBehaviour
    {
        private static Camera _camera;

        private void Start()
        {
            _camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        }

        public static Vector3 getCameraForwardDirection()
        {
            return _camera.gameObject.transform.forward;
        }

        public static Vector3 getCameraRightDirection()
        {
            return _camera.gameObject.transform.right;
        }

        public static Vector3 getCameraForwardDirectionNormalized()
        {
            Vector3 forward = getCameraForwardDirection();
            forward.y = 0;
            return forward.normalized;
        }

        public static Vector3 getCameraRightDirectionNormalized()
        {
            Vector3 right = getCameraRightDirection();
            right.y = 0;
            return right.normalized;
        }
    }
}