//Last Edit: 2017.03.08 09:41
//201513161 과제 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
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
            new Vector3(-1.25f, 9.0f, 0.0f),//11 Clavicle Left
            new Vector3(1.25f, 9.0f, 0.0f),//12 Clavicle Right

            new Vector3(-0.625f, 9.25f, 0.0f),//13 Neck Left
            new Vector3(0.625f, 9.25f, 0.0f),//14 Neck Right

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


            new Vector3(-3.125f, 7.5f, 0.0f),//34 Elbow Left
            new Vector3(3.125f, 7.5f, 0.0f),//35 Elbow Right
            new Vector3(-3.125f, 8.0f, 0.0f),//36 Elbow Up Left
            new Vector3(3.125f, 8.0f, 0.0f),//37 Elbow Up Right

            new Vector3(-0.3f, 2.5f, 0.0f),//38 Knee Left In
            new Vector3(0.3f, 2.5f, 0.0f),//39 Knee Right In
        };

        m.triangles = new int[]
        {
            1, 2, 0, //Pelvis
			1, 0, 3, 3, 0, 38, 3, 38, 6, 3, 6, 5,
            0, 2, 4, 0, 4, 39, 39, 4, 8, 4, 7, 8,

            9, 2, 1, 9, 10, 2, 11, 13, 9, 9, 13, 10, 13, 14, 10, 14, 12, 10,

            15, 36, 34, 36, 11, 34, 34, 11, 9, 17, 15, 16,
            37, 18, 35, 12, 37, 35, 12, 35, 10, 18, 20, 19,

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
			bones[12].worldToLocalMatrix*bones[0].worldToLocalMatrix,
            bones[13].worldToLocalMatrix*bones[0].worldToLocalMatrix,
            bones[14].worldToLocalMatrix*bones[0].worldToLocalMatrix,
            bones[15].worldToLocalMatrix*bones[0].worldToLocalMatrix,
            bones[16].worldToLocalMatrix*bones[0].worldToLocalMatrix,
            bones[17].worldToLocalMatrix*bones[0].worldToLocalMatrix
        };

        m.uv = new Vector2[]
        {
            new Vector2(0.0f+0.5f, 3.75f/15f),//0 Pelvis
            new Vector2(-1.25f/15f+0.5f, 5.0f/15f),//1 Pelvis Left
            new Vector2(1.25f/15f+0.5f, 5.0f/15f),//2 Pelvis Right

            new Vector2(-1.25f/15f+0.5f, 2.5f/15f),//3 Knee Left
            new Vector2(1.25f/15f+0.5f, 2.5f/15f),//4 Knee Right

            new Vector2(-1.25f/15f+0.5f, 0.0f),//5 Foot Left Out
            new Vector2(-0.625f/15f+0.5f, 0.0f),//6 Foot Left In
            new Vector2(1.25f/15f+0.5f, 0.0f),//7 Foot Right Out
            new Vector2(0.625f/15f+0.5f, 0.0f),//8 Foot Right In


            new Vector2(-1.25f/15f+0.5f, 7.5f/15f),//9 Torso Left
            new Vector2(1.25f/15f+0.5f, 7.5f/15f),//10 Torso Right
            new Vector2(-1.25f/15f+0.5f, 8.75f/15f),//11 Clavicle Left
            new Vector2(1.25f/15f+0.5f, 8.75f/15f),//12 Clavicle Right

            new Vector2(-0.625f/15f+0.5f, 9.25f/15f),//13 Neck Left
            new Vector2(0.625f/15f+0.5f, 9.25f/15f),//14 Neck Right

            new Vector2(-5.0f/15f+0.5f, 7.5f/15f),//15 Arm Left
            new Vector2(-5.0f/15f+0.5f, 6.875f/15f),//16 Left Thumb
            new Vector2(-6.25f/15f+0.5f, 7.5f/15f),//17 Left Fingers
            
            new Vector2(5.0f/15f+0.5f, 7.5f/15f),//18 Arm Right
            new Vector2(5.0f/15f+0.5f, 6.875f/15f),//19 Right Thumb
            new Vector2(6.25f/15f+0.5f, 7.5f/15f),//20 Right Fingers


            new Vector2(0.0f+0.5f, 13.125f/15f),//21 Head Top

            new Vector2(-1.25f/15f+0.5f, 12.5f/15f),//22 Ear Start Left
            new Vector2(1.25f/15f+0.5f, 12.5f/15f),//23 Ear Start Right

            new Vector2(-1.25f/15f+0.5f, 11.25f/15f),//24 Cheek Left
            new Vector2(1.25f/15f+0.5f, 11.25f/15f),//25 Cheek Right

            new Vector2(-2.5f/15f+0.5f, 11.25f/15f),//26 Fluff Left
            new Vector2(2.5f/15f+0.5f, 11.25f/15f),//27 Fluff Right

            new Vector2(-0.625f/15f+0.5f, 10.0f/15f),//28 Jaw Left
            new Vector2(0.625f/15f+0.5f, 10.0f/15f),//29 Jaw Right

            new Vector2(-2.5f/15f+0.5f, 12.5f/15f),//30 Ear Left
            new Vector2(-2.5f/15f+0.5f, 15.0f/15f),//31 Ear Tip Left
            new Vector2(2.5f/15f+0.5f, 12.5f/15f),//32 Ear Right
            new Vector2(2.5f/15f+0.5f, 15.0f/15f),//33 Ear Tip Right


            new Vector2(-3.125f/15f+0.5f, 7.5f/15f),//34 Elbow Left
            new Vector2(3.125f/15f+0.5f, 7.5f/15f),//35 Elbow Right
            new Vector2(-3.125f/15f+0.5f, 8.0f/15f),//36 Elbow Up Left
            new Vector2(3.125f/15f+0.5f, 8.0f/15f),//37 Elbow Up Right

            new Vector2(-0.3f/15f+0.5f, 2.5f/15f),//38 Knee Left In
            new Vector2(0.3f/15f+0.5f, 2.5f/15f)//39 Knee Right In
        };

        m.boneWeights = new BoneWeight[]
        {
            new BoneWeight() { boneIndex0 = 1, weight0 = 1f},
            new BoneWeight() { boneIndex0 = 2, weight0 = 0.75f , boneIndex1 = 6, weight1 = 0.25f },
            new BoneWeight() { boneIndex0 = 4, weight0 = 0.75f , boneIndex1 = 6, weight1 = 0.25f },

            new BoneWeight() { boneIndex0 = 3, weight0 = 1f},
            new BoneWeight() { boneIndex0 = 5, weight0 = 1f},

            new BoneWeight() { boneIndex0 = 3, weight0 = 1f},
            new BoneWeight() { boneIndex0 = 3, weight0 = 1f},
            new BoneWeight() { boneIndex0 = 5, weight0 = 1f},
            new BoneWeight() { boneIndex0 = 5, weight0 = 1f},

            new BoneWeight() { boneIndex0 = 7, weight0 = 0.75f, boneIndex1 = 6, weight1 = 0.25f },
            new BoneWeight() { boneIndex0 = 7, weight0 = 0.75f, boneIndex1 = 6, weight1 = 0.25f },
            new BoneWeight() { boneIndex0 = 8, weight0 = 0.9f, boneIndex1 = 7, weight1 = 0.1f },
            new BoneWeight() { boneIndex0 = 11, weight0 = 0.9f, boneIndex1 = 7, weight1 = 0.1f },

            new BoneWeight() { boneIndex0 = 14, weight0 = 0.8f, boneIndex1 = 8, weight1 = 0.2f },
            new BoneWeight() { boneIndex0 = 14, weight0 = 0.8f, boneIndex1 = 11, weight1 = 0.2f },

            new BoneWeight() { boneIndex0 = 10, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 10, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 10, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 13, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 13, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 13, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 15, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 15, weight0 = 0.9f, boneIndex1 = 16, weight1 = 0.1f },
            new BoneWeight() { boneIndex0 = 15, weight0 = 0.9f, boneIndex1 = 17, weight1 = 0.1f },

            new BoneWeight() { boneIndex0 = 15, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 15, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 15, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 15, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 15, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 15, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 16, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 16, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 17, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 17, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 9, weight0 = 0.9f, boneIndex1 = 8, weight1 = 0.1f },
            new BoneWeight() { boneIndex0 = 12, weight0 = 0.9f, boneIndex1 = 11, weight1 = 0.1f },
            new BoneWeight() { boneIndex0 = 9, weight0 = 0.9f, boneIndex1 = 8, weight1 = 0.1f },
            new BoneWeight() { boneIndex0 = 12, weight0 = 0.9f, boneIndex1 = 11, weight1 = 0.1f },

            new BoneWeight() { boneIndex0 = 3, weight0 = 1f},
            new BoneWeight() { boneIndex0 = 5, weight0 = 1f}
        };

        GetComponent<MeshFilter>().mesh = m;
        GetComponent<SkinnedMeshRenderer>().sharedMesh = m;
        GetComponent<SkinnedMeshRenderer>().bones = bones;
        GetComponent<SkinnedMeshRenderer>().quality = SkinQuality.Bone2;
    }
}
