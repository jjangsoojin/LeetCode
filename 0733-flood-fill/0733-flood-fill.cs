public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
      int startingColor = image[sr][sc];

     // 시작 픽셀이 이미 원하는 색상이면 아무 작업도 필요하지 않음
     if (startingColor != color)
     {
         PerformFloodFill(image, sr, sc, startingColor, color);
     }

     return image;
 }

 private void PerformFloodFill(int[][] image, int row, int col, int startingColor, int color)
 {
     // 현재 픽셀이 배열 경계를 벗어나거나 이미 색상이 변경된 경우 종료
     if (row < 0 || row >= image.Length || col < 0 || col >= image[0].Length || image[row][col] != startingColor)
     {
         return;
     }

     // 현재 픽셀의 색상 변경
     image[row][col] = color;

     // 상하좌우로 재귀적으로 홍수 채우기 수행
     PerformFloodFill(image, row + 1, col, startingColor, color); // 아래
     PerformFloodFill(image, row - 1, col, startingColor, color); // 위
     PerformFloodFill(image, row, col + 1, startingColor, color); // 오른쪽
     PerformFloodFill(image, row, col - 1, startingColor, color); // 왼쪽
 }
}