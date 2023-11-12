using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data : MonoBehaviour
{
    static GameObject _container;

    static GameObject Container
    {
        get
        {
            return _container;
        }
    }
    static Data _instance;

    public static Data Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "Data";
                _instance = _container.AddComponent(typeof(Data)) as Data;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    public string GameDataFileName = "SunMoon_And.json";  //�̸� ���� ���� X 



    public GameData _gameData;

    public GameData gameData
    {
        get
        {
            if (_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }

    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;
        if (File.Exists(filePath))
        {
            Debug.Log("�ҷ����� ����!");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }
        else
        {
            Debug.Log("���ο� ���� ����");
            _gameData = new GameData();
        }
    }

    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);
        string filePath = Application.persistentDataPath + GameDataFileName;
        File.WriteAllText(filePath, ToJsonData);
        Debug.Log("���� �Ϸ�");
    }
    private void OnApplicationQuit()
    {
        Data.Instance.gameData.stage_return = 0;
        SaveGameData();
    }
}
