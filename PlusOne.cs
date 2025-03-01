public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> result = new List<int>(digits);
        int carry = 1; 

        for (int i = result.Count - 1; i >= 0; i--) {
            int sum = result[i] + carry;
            result[i] = sum % 10; 
            carry = sum / 10; 

            if (carry == 0) break; 
        }

        if (carry > 0) {
            result.Insert(0, carry);
        }

        return result.ToArray();
    }
}