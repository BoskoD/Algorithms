# Note to Myself

| Topic  | Algorithm  | Apporach |
| :------------ |:--------------- |:----- |
| Array, HashTable      | TwoSum | It uses a Dictionary (**HashTable**) as a data structure to store the elements of the array along with their indices. While iterating through the array, for each element nums[i], it calculates target - nums[i] and checks if this value is already present in the Dictionary. If found, it means there is a valid pair of elements whose sum is equal to the target value. |
| String, Stack         | ValidParentheses | It uses a **Stack** data structure to keep track of the opening brackets while iterating through the input string. Whenever an opening bracket is encountered, it is pushed onto the stack. When a closing bracket is found, it is checked if its corresponding opening bracket is at the top of the stack. If so, the opening bracket is popped from the stack. The algorithm continues this process until the end of the string. If the stack becomes empty at the end, the string contains valid parentheses; otherwise, it is not valid. |
| Array, HashTable, Recursion | ContainsDuplicate | It employs a **HashSet** data structure to keep track of unique elements encountered while iterating through the array. For each element in the array, it attempts to add it to the HashSet using the Add method. If the Add method returns false, it means the element already exists in the HashSet, indicating a duplicate in the array. |
| LinkedList, Recursion | MergeTwoSortedLists | It uses a **recursive** approach to handle different cases when comparing nodes from both lists. The base cases are when one of the lists is empty, in which case the other list is returned. If neither list is empty, it checks whether the val of the first node in list1 is less than or equal to the val of the first node in list2. Depending on the result, it recursively sets the next node of the current list to the result of merging the rest of the lists. |
| HashTable, String, Sorting | Valid Anagram | Use 2 **HashTable** to count each letter in both strings, then compare counts to validate. Anagram is valid if all chars from sCounter have the same count as tCounter. |
| Array, HashTable, String, Sorting | Group Anagrams | Takes an array of strings as input, iterate through each string, and generate a key by counting the occurrences of each character. **Example hash[c - 'a']++.** Strings with the same key are considered anagrams, and they are grouped together in the dictionary. Finally, the method returns a list of lists, where each list represents a group of anagrams. |
| Two Pointers, String | Valid Palindrome | Takes a string as input, use **two pointers**, while they do not meet, check for all characters, are they digit or letter IsLetterOrDigit(s[left]) and IsLetterOrDigit(s[right]), if not move pointers left++ and right--, if they are letter or digit, unify them all - ToLower() and check if left char is equal to right char. |