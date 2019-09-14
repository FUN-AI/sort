
void setup() {
  int n = 256*256;
  int a[] = new int[n];
  for (int i = 0; i < a.length; i++) a[i] = int(random(100));

  float m = millis();
  a = StoogeSort(a, true);
  println(a);
  println("実行時間：", (millis()-m)+"ms");
  exit();
}

int[] StoogeSort(int n[], boolean asc) {
  return StoogeSort(n, 0, n.length-1, asc);
}

int[] StoogeSort(int n[], int L, int R, boolean asc) {
  if (asc == n[L] > n[R]) {
    int tmp = n[L];
    n[L] = n[R];
    n[R] = tmp;
  }
  if (R - L + 1 >= 3) {
    int t = (R - L + 1) / 3;
    n = StoogeSort(n, L, R-t, asc);
    n = StoogeSort(n, L+t, R, asc);
    n = StoogeSort(n, L, R-t, asc);
  }
  return n;
}
