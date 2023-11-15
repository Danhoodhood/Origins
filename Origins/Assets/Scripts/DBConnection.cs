using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;

public class DBConnection : MonoBehaviour
{
    public SqliteConnection dbconection;
    private string path;


    void Start()
        
    {
        setConection();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setConection()
    {
        path = Application.dataPath + "/StreamingAssets/BDGame.bd";
        dbconection = new SqliteConnection("Data Source=" + path);

        dbconection.Open();
        if (dbconection.State == ConnectionState.Open)
        {
            SqliteCommand cmd = new SqliteCommand();
            cmd.Connection = dbconection;
            cmd.CommandText = "SELECT * FROM Kards";
            SqliteCommand cmd2 = new SqliteCommand();
            cmd2.Connection = dbconection;
           /* cmd2.CommandText= "SELECT * FROM Kards";


            SqliteDataReader r = cmd2.ExecuteReader();
            while (r.Read())
            {
                 Debug.Log(String.Format("{0} {1}", r[0], r[1]));

            }*/

        }
        else
        {
            Debug.Log("Error Connection");
        }
    }
}

