using UnityEngine;

[System.Serializable]
public struct AccelerometerStuffStruct {
    public int count;
    public float deltaTime;
    public Vector3 values;

    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 gforce;

    public string movementType;

    public AccelerometerStuffStruct(int count, float deltaTime, Vector3 values, Vector3 pos1, Vector3 pos2, Vector3 gforce, string movementType) {
        this.count = count;
        this.deltaTime = deltaTime;
        this.values = values;
        this.pos1 = pos1;
        this.pos2 = pos2;
        this.gforce = gforce;
        this.movementType = movementType;
    }
}

[System.Serializable]
public struct DeltaPositionsStruct {
    public int count;
    public float deltaTime;
    public Vector3 values;
    public Vector3 gForce;
    public string movementType;

    public DeltaPositionsStruct(int count, float deltaTime, Vector3 values, Vector3 gForce, string movementType) {
        this.count = count;
        this.deltaTime = deltaTime;
        this.values = values;
        this.gForce = gForce;
        this.movementType = movementType;
    }
}

public static class ConstantsMovements {
    public static string idle = "Idle";
    public static string fall = "Fall";
    public static string walking = "Walking";
    public static string after_fall = "After_fall";
    public static string transition = "Transition";
}