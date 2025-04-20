using System;

namespace PalindromeExercise
{
    public class Palindrome
    {
        public bool IsAPalindrome(string word)//wouldn't the word variable have to be treated as a character type, and not a string?
        {
            //throw new NotImplementedException();

            //Strategy; first find a way to reverse the word, then compare the original word with the reversed word, and return whether or not they are the same.

            //Reverse -- racecar as an example; length of the word racecar equals 7 characters, therefore its last index would be 6.
            var reversed = "";
            //string reversed;
            //char reversed;//this actually did enable the for loop's scope to function without error, but then it wouldn't have done what was needed of it, which would have been to leverage i as a sort of parser of the word array, and incrementing the reversed string, but it's incrementing it with type i, which is the char type.... interesting. I'm used to leveraging i within the context of integers, not for strings or chars.
            //Compare
            for (int i = word.Length - 1; i >= 0; i--)//for (int i = 0; i < word.Length; i++)//remember to account for the 0 index. In the case of racecar this would literally read as i equals index of word's array length minus 1, which gives its sixth index, and i will decrement by 1 until it reaches 0. 7 total indexes, matching 7 total letters in the word.
            {//I'm guessing that because of how for loops are formatted in c#, that there must be a minium of 3 conditonals for any of them.
                reversed += word[i];//gives me an error if I don't have the reversed variable defined as a char type.... exactly what I anticipated as mentioned above....though I don't see exactly why C# gets so upset about an attempt to implicitly convert a char type character to string.
            }//figured out the error; it was syntactic, as is typical in my experience here.... I'm guessing that the equals sing in the line of code above 'implicitly' converts a char type to a string type, whereas the plus - minus sign doesn't?
            //Compare the original word with its reversed form
            if (reversed == word)//since reversed retains its string type here in this if loop, and so does word, they can logically be compared as the same type, which is essential in order for such a comparison to be valid; to work in C#.
            {//I would have attempted to have come up with something that entailed counting the number of characters for a given array that gets passed into the method, but doing that would inhibit whether or not all of that array's characters actually match the ones in the array's reversed form.... so of course utilizing arrays initially defined as strings would make sense here, but then makes me wonder.... what does an array of character types look like?
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
