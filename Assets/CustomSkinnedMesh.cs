//Last Edit: 2017.03.08 09:41
//201513161 김다영 수업 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinnedMesh : MonoBehaviour
{
    public Transform[] bones;

    // Use this for initialization
    void Start()
    {
        Mesh m = new Mesh();

        m.vertices = new Vector3[]
        {
            new Vector3(0.0f, 3.75f, 0.0f),//0 Pelvis
            new Vector3(-1.25f, 5.0f, 0.0f),//1 Pelvis Left
            new Vector3(1.25f, 5.0f, 0.0f),//2 Pelvis Right

            new Vector3(-1.25f, 2.5f, 0.0f),//3 Knee Left
            new Vector3(1.25f, 2.5f, 0.0f),//4 Knee Right

            new Vector3(-1.25f, 0.0f, 0.0f),//5 Foot Left Out
            new Vector3(-0.625f, 0.0f, 0.0f),//6 Foot Left In
            new Vector3(1.25f, 0.0f, 0.0f),//7 Foot Right Out
            new Vector3(0.625f, 0.0f, 0.0f),//8 Foot Right In


            new Vector3(-1.25f, 7.5f, 0.0f),//9 Torso Left
            new Vector3(1.25f, 7.5f, 0.0f),//10 Torso Right
            new Vector3(-1.25f, 8.75f, 0.0f),//11 Clavicle Left
            new Vector3(1.25f, 8.75f, 0.0f),//12 Clavicle Right

            new Vector3(-0.625f, 9.0f, 0.0f),//13 Neck Left
            new Vector3(0.625f, 9.0f, 0.0f),//14 Neck Right

            new Vector3(-5.0f, 7.5f, 0.0f),//15 Arm Left
            new Vector3(-5.0f, 6.875f, 0.0f),//16 Left Thumb
            new Vector3(-6.25f, 7.5f, 0.0f),//17 Left Fingers

            new Vector3(5.0f, 7.5f, 0.0f),//18 Arm Right
            new Vector3(5.0f, 6.875f, 0.0f),//19 Right Thumb
            new Vector3(6.25f, 7.5f, 0.0f),//20 Right Fingers


            new Vector3(0.0f, 13.125f, 0.0f),//21 Head Top

            new Vector3(-1.25f, 12.5f, 0.0f),//22 Ear Start Left
            new Vector3(1.25f, 12.5f, 0.0f),//23 Ear Start Right

            new Vector3(-1.25f, 11.25f, 0.0f),//24 Cheek Left
            new Vector3(1.25f, 11.25f, 0.0f),//25 Cheek Right

            new Vector3(-2.5f, 11.25f, 0.0f),//26 Fluff Left
            new Vector3(2.5f, 11.25f, 0.0f),//27 Fluff Right

            new Vector3(-0.625f, 10.0f, 0.0f),//28 Jaw Left
            new Vector3(0.625f, 10.0f, 0.0f),//29 Jaw Right

            new Vector3(-2.5f, 12.5f, 0.0f),//30 Ear Left
            new Vector3(-2.5f, 15.0f, 0.0f),//31 Ear Tip Left
            new Vector3(2.5f, 12.5f, 0.0f),//32 Ear Right
            new Vector3(2.5f, 15.0f, 0.0f),//33 Ear Tip Right
        };

        m.triangles = new int[]
        {
            1, 2, 0, //Pelvis
			1, 0, 3, 0, 2, 4, 3, 0, 6, 0, 4, 8, 3, 6, 5, 8, 4, 7,
            9, 2, 1, 9, 10, 2, 11, 13, 9, 9, 13, 10, 13, 14, 10, 14, 12, 10,
            15, 11, 9, 17, 15, 16, 12, 18, 10, 18, 20, 19,
            28, 14, 13, 28, 29, 14,
            26, 24, 28, 24, 29, 28, 24, 25, 29, 25, 27, 29, 22, 25, 24, 22, 23, 25, 22, 21, 23,
            31, 22, 30, 23, 33, 32 //Ears
        };
		
		//Set Bindpose
        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix*bones[0].worldToLocalMatrix,
            bones[1].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[2].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[3].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[4].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[5].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[6].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[7].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[8].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[9].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[10].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[11].worldToLocalMatrix*bones[0].worldToLocalMatrix,
			bones[12].worldToLocalMatrix*bones[0].worldToLocalMatrix
        };

        /*
        m.uv = new Vector2[]
        {
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 1.0f),
            new Vector2(1.0f, 1.0f),
            new Vector2(1.0f, 0.0f)
        };

        m.boneWeights = new BoneWeight[]
        {
            new BoneWeight() { boneIndex0 = 0, weight0 = 1f, boneIndex1 = 1, weight1 = 0f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 0.0f, boneIndex1 = 1, weight1 = 1.0f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 0.4f, boneIndex1 = 1, weight1 = 0.6f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 0.4f, boneIndex1 = 1, weight1 = 0.6f }
        };
        */


        GetComponent<MeshFilter>().mesh = m;
        GetComponent<SkinnedMeshRenderer>().sharedMesh = m;
        GetComponent<SkinnedMeshRenderer>().bones = bones;
        GetComponent<SkinnedMeshRenderer>().quality = SkinQuality.Bone2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinnedMesh : MonoBehaviour
{
    public Transform [] bones;

	// Use this for initialization
	void Start ()
    {
        Mesh m = new Mesh();

        m.vertices = new Vector3[]
        {
            new Vector3(0.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 3.0f, -3.0f),
            new Vector3(-3.0f, 3.0f, 0.0f),
            new Vector3(3.0f, 3.0f, 0.0f)
        };

        m.triangles = new int[] { 0, 2, 1, 0, 3, 2, 0, 1, 3, 1, 2, 3 };
        m.uv = new Vector2[]
        {
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 1.0f),
            new Vector2(1.0f, 1.0f),
            new Vector2(1.0f, 0.0f)
        };

        m.colors = new Color[]
        {
            new Color(0.2f, 0.45f, 1.0f),
            new Color(1.0f, 0.925f, 0.25f),
            new Color(0.1f, 1f, 0.45f),
            new Color(0.95f, 0.55f, 0.8f)
        };

        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix*bones[0].worldToLocalMatrix,
            bones[1].worldToLocalMatrix*bones[0].worldToLocalMatrix,
        };

        m.boneWeights = new BoneWeight[]
        {
            new BoneWeight() { boneIndex0 = 0, weight0 = 1f, boneIndex1 = 1, weight1 = 0f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 0.0f, boneIndex1 = 1, weight1 = 1.0f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 0.4f, boneIndex1 = 1, weight1 = 0.6f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 0.4f, boneIndex1 = 1, weight1 = 0.6f }
        };

        GetComponent<MeshFilter>().mesh = m;
        GetComponent<SkinnedMeshRenderer>().sharedMesh = m;
        GetComponent<SkinnedMeshRenderer>().bones = bones;
        GetComponent<SkinnedMeshRenderer>().quality = SkinQuality.Bone2;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
*/
