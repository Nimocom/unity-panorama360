using UnityEngine;
using SK.GyroscopeWebGL;

    public class GyroscopeReader : MonoBehaviour
    {
        [SerializeField] Transform acCamera;

        private void Start()
        {
            SK_DeviceSensor.StartGyroscopeListener(OnGyroscopeReading);
        }

        void OnDestroy()
        {
            SK_DeviceSensor.StopGyroscopeListener();
        }

        private void OnGyroscopeReading(GyroscopeData reading)
        {
            acCamera.transform.rotation = reading.UnityRotation;
        }
    }
