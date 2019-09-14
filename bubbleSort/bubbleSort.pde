// どちらかというとオリジナルのmaxSort

void setup() {
  int n = 256;
  int a[] = new int[n];
  for (int i = 0; i < a.length; i++) a[i] = int(random(100));

  float m = millis();
  a = bubbleSort(a, true);
  println(a);
  println("実行時間：", (millis()-m)+"ms");
  exit();
}

// うまいこと変えればクラスでも並べ可能なはず（ただし処理速度...）
int[] bubbleSort(int n[], boolean asc) {
  for (int i = n.length-1; i > 0; i--) {  // 番地が大きいところから確定していく
    int k = i;
    for (int j = 0; j < i; j++) if (asc == (n[k] < n[j])) k = j;  // 最大を探す
    if (k != i) {
      int tmp = n[k];
      n[k] = n[i];
      n[i] = tmp;
    }
  }
  return n;
}
