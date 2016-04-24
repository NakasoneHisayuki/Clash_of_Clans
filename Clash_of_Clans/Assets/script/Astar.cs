using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// エッジクラス
class Edge{
	// 接続先のノード番号
	public int To;
	// コスト
	public int Cost;
//	
//	// コンストラクタ
	public Edge(int to, int cost)
	{
//		this.To = to;
//		this.Cost = cost;
	}
}

class Node{
	// このノードから伸びるエッジの情報
//	public Edge[] Edges;
//	
//	// エースター法のためのデータ
//	public int Cost;        // このノードへの現時点で判明している最小コスト
//	public int No;           // このノード番号（最短経路確認用）
//	public int From;        // 親のノード番号（最短経路確認用）
//	public string Name;    // ノード名称（最短経路確認用）
//	public Vector2 Pos;   // ノードの座標（最短経路確認用）
//	
//	// コンストラクタ
//	public Node(int no, string name, Vector2 pos, Edge[] edges)
//	{
//		this.No = no;
//		this.Name = name;
//		this.Pos = pos;
//		this.Edges = edges;
//		
//		this.Cost = costMax;
//		this.From = -1;
//	}
}

public class Astar : MonoBehaviour {

	public GameObject[] cubeObj1;
	public GameObject[] cubeObj2;
	public GameObject[] cubeObj3;
	public GameObject[] cubeObj4;
	public GameObject[] cubeObj5;

//	public List<Node> test = new List<Node>();
	private Dictionary<int,string> dic = new Dictionary<int,string>(){
		{ 0, "test" },
		{ 1, "バナナ" },
		{ 2, "チョコレート" },
	};
//	private List<int> intList = new List<int>();
//	private List<Dictionary<int, string>> intList = new List<Dictionary<int, string>>(){
//		{ 0{0, "test"} },
//	};



	// Use this for initialization
	void Start () {
		list();
		Debug.Log(dic[0]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void list(){


//		this.dic.Add(0,1);
//		Debug.Log(dic[1]);
//		intList.Add(new Dictionary<int, string>() { {0, "test"} });
//		this.intList.Add(0,"test");
//		this.intList.Add(2);
//		Debug.Log(intList[0]);

	}

//	public ANode SearchMinScoreNodeFromOpenList() {
//		// 最小スコア
//		int min = 9999;
//		// 最小実コスト
//		int minCost = 9999;
//		ANode minNode = null;
//		foreach(ANode node in _openList) {
//			int score = node.GetScore();
//			if(score > min) {
//				// スコアが大きい
//				continue;
//			}
//			if(score == min && node.Cost >= minCost) {
//				// スコアが同じときは実コストも比較する
//				continue;
//			}
//			
//			// 最小値更新.
//			min = score;
//			minCost = node.Cost;
//			minNode = node;
//		}
//		return minNode;
//	}
}
