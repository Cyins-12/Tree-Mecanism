using UnityEngine;

public class WaterDroplet : MonoBehaviour
{
    public float waterAmount = 0.05f; // Jumlah nilai slider yang ditambahkan

    void OnCollisionEnter(Collision collision)
    {
        // Cek jika yang terkena adalah Soil
        Soil soil = collision.gameObject.GetComponent<Soil>();
        if (soil != null)
        {
            // Tambahkan nilai slider pada Soil
            soil.AddWateringSliderValue(waterAmount);
        }

        // Hapus tetesan air setelah mengenai objek
        Destroy(gameObject);

    }
}
