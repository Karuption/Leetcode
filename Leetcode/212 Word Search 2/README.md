# Runtime
598ms, beats 80.46%

# Memory
49.1 MB, beats 44.3%

# Approach
1. Take all of the possible words and insert them into a Trie
2. Take element [n,m] and search the try
   1. If the element is found, search it with its neighbors to see if this forms a prefix.
   2. If an entire word is found, remove the prefix from the Trie and add this to an output HashSet and keep searching (this may be a subword).
3. Once all of the elements on the board have been searched for, return the output HashSet.