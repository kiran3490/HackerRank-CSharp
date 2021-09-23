class Result
{

    /*
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int minimumAbsoluteDifference(List<int> arr)
    {
            int result = int.MaxValue;

            // Sort array, It will help to loop only once, instead of two times
            arr.Sort();

            for(int i =1; i<arr.Count; i++){
                    int absoluteSum = Math.Abs(arr[i-1] - arr[i]);

                    if(absoluteSum < result)
                        result = absoluteSum;  
            }

            return result;
    }
}
