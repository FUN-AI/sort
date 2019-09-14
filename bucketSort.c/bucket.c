#include <stdio.h>

void bucket(int *array, int n){
	// 最大値を見つける
	int max = array[0];
	for(int i = 1;i < n;i++) if(max < array[i]) max = array[i];

	// 最小値を見つける
	int min = array[0];
	for(int i = 1;i < n;i++) if(min > array[i]) min = array[i];

	// バケットに入れる
	int b[max-min+1];
	for(int i = 0;i < max-min+1;i++) b[i] = 0;
	for(int i = 0;i < n;i++) b[array[i]-min]++;

	// 元の配列に入れる
	int ct = 0;
	for(int i = 0;i < max-min+1;i++) for(int j = 0;j < b[i];j++) array[ct++] = min + i;
}

int main(void){
	// データを用意する
	int n = 256;
	int array[n];
	for(int i = 0;i < n;i++) array[i] = rand()%100+1;

	// ソートを行う
	bucket(array, n);

	// 表示をする
	for(int i = 0;i < n;i++) printf("%d\n", array[i]);

	return 0;
}
