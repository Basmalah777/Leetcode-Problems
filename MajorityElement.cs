public class Solution {
    //Boyer-Moore Voting Algorithm   استخدمت خوارزميه
    public int FindMajority(int[] numbers) {  
        int majorityCandidate = numbers[0];
        int frequency = 1;

        for (int i = 1; i < numbers.Length; i++) {
            if (numbers[i] == majorityCandidate) {
                frequency++;
            } else {
                frequency--;
                if (frequency == 0) {
                    majorityCandidate = numbers[i];
                    frequency = 1;
                }
            }
        }
        return majorityCandidate;
    }
}
