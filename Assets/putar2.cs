using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class putar2 : MonoBehaviour
{
public float kecepatanPutar = 50f; //Kecepatan rotasi objek, diatur default ke 50 unit.
private bool rotateStatus = false;
// Update is called once per frame
void Update()
{
if (rotateStatus)
{
transform.Rotate(Vector3.up * Time.deltaTime * kecepatanPutar);
} // Metode ini dipanggil setiap frame. Jika rotateStatus adalah true, objek akan diputar di sekitarsumbu Y (Vector3.up) dengan kecepatan kecepatanPutar dikalikan dengan Time.deltaTime (untukmemastikan rotasi konsisten dengan waktu frame).
}
// Metode untuk mengaktifkan atau menonaktifkan rotasi
public void ToggleRotasi()
{
rotateStatus = !rotateStatus;
}
}
