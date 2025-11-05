public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // step 1: create an empty array the size of the length
        double[] multiples = new double[length];

        // step 2: use for loop to fill empty array with multiples of number
        for (int i = 0; i < length; i++)
        {
            // uses iterator for array index and multiplier, so multiplier needs 1 added
            multiples[i] = number * (i + 1);
        }
        // step 3: return the array
            return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // step 1: get list of items at end of list and insert at beginning        
        data.InsertRange(0, data.GetRange(data.Count - amount, amount));

        // step 2: remove items at end
        data.RemoveRange(data.Count - amount, amount);
        
        // notes: this solution does not work if rotating more steps than there are items in the list
        // that would be possible with a loop that moves one number at a time
    }
}
