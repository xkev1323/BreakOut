using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public abstract class PuntajePersistente : ScriptableObject
{
    public void Guardar(string nombreArchivo = null)
    {
        var ruta = ObtenerRuta(nombreArchivo);
        var bf = new BinaryFormatter();
        var file = File.Create(ruta);
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }

    public virtual void Cargar(string nombreArchivo = null)
    {
        var ruta = ObtenerRuta(nombreArchivo);
        if (!File.Exists(ruta))
        {
            Debug.LogWarning("El archivo no existe: " + ruta);
            return;
        }
        var bf = new BinaryFormatter();
        var file = File.Open(ruta, FileMode.Open);
        var json = (string)bf.Deserialize(file);
        JsonUtility.FromJsonOverwrite(json, this);
        file.Close();
    }

    public string ObtenerRuta(string nombreArchivo = null)
    {
        var nombreArchivoCompleto = string.IsNullOrEmpty(nombreArchivo) ? name : nombreArchivo;
        return string.Format("{0}/{1}.ebac", Application.persistentDataPath, nombreArchivoCompleto);
    }
}
