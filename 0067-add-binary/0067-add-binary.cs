public class Solution {
    public string AddBinary(string a, string b) {
        
        /*
 StringBuilder는 변경할 수 없는 string과 달리 변경 가능한 문자열을 나타내는데 사용하는 클래스입니다. 
 string 객체는 값이 변경되면 메모리에서 이전 참조 값을 버리고 새로운 참조 값으로 변경되지만,
 StringBuilder 객체는 참조 값이 변경되지 않고 힙 메모리에서 값이 삽입, 추가, 제거됩니다. 
 */

StringBuilder result = new StringBuilder();

int carry = 0;              // 올림값을 저장하는 변수
int i = a.Length - 1;       // 각 이진수의 마지막 자릿수부터 시작
int j = b.Length - 1;

while (i >= 0 || j >= 0 || carry > 0)       // 이진수의 자릿수를 모두 처리하고 올림값이 남아있는 동안 반복
{
    int sum = carry;        // 현재 자릿수의 합에 이전까지의 올림값을 더함

    if (i >= 0)
    {
        sum += a[i] - '0';  // 현재 자릿수의 값을 더함 // '0' - 해당 문자의 숫자값을 가져오는 것(문자를 숫자로 변환하는 작업)
        i--;
    }

    if (j >= 0)
    {
        sum += b[j] - '0';
        j--;
    }

    result.Insert(0, sum % 2);  //  현재 자릿수의 합을 이진수 결과의 처음에 추가  //StringBuilder.Insert - 현재 StringBuilder의 지정된 인덱스에 문자열 또는 개체를 삽입합니다.
    carry = sum / 2;    // 다음 자릿수로 넘어갈 올림값을 계산
}

return result.ToString();
    }
}