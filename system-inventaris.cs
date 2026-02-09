using UnityEngine;

public class InventarisBerat :
MonoBehaviour
{
    void Start()
    {
        int jumlahBatu = 3;
        float beratPerBatu = 4.5f;
        float kapasitasMaks = 10.0f;

        float totalBeban = jumlahBatu * beratPerBatu;
        bool isOverweight = totalBeban > kapasitasMaks;

        Debug.Log("Total beban: " + totalBeban + "kg. Apakah tas keberatan? " + isOverweight);
    }
}