using UnityEngine;

public class KalkulatorKecepatan :
MonoBehaviour
{
    void Start()
    {
        float jarak = 100.5f;
        float waktu = 10.0f;

        float kecepatan = jarak / waktu;

        Debug.Log("Mobil menempuh jarak " + jarak + "meter dalam" + waktu + "detik. kecepatan:" + kecepatan + "m/s.");
    }
}